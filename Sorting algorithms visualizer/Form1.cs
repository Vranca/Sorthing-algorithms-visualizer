using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sorting_algorithms_visualizer
{
    public partial class Form1 : Form
    {
        int[] array;
        int size;
        float sizeToMax;

        Boolean sorting = false;
        Boolean pause = false;

        Bitmap arrayImage;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            tbArraySize.Maximum = pbArrayDisplay.Width;

            Random rnd = new Random();
            size = tbArraySize.Value;
            sizeToMax = (float)size / (float)tbArraySize.Maximum; 
            array = Enumerable.Range(1, size).OrderBy(x => rnd.Next()).ToArray();

            drawArray(array);
        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            btnSortingMethod.Text = btn.Text;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            size = tbArraySize.Value;
            sizeToMax = (float)size / (float)tbArraySize.Maximum;
            array = Enumerable.Range(1, size).OrderBy(x => rnd.Next()).ToArray();
            gbArraySize.Text = "Array size: " + size.ToString();
            drawArray(array);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = false;
            btnStop.Enabled = true;
            btnPause.Enabled = true;
            tbArraySize.Enabled = false;
            tbSortingSpeed.Enabled = false;
            btnSortingMethod.Enabled = false;

            if (pause)
            {
                pause = false;
            }
            else
            {
                sorting = true;
                int sortingSpeed = tbSortingSpeed.Value;

                var thread = new System.Threading.Thread(() =>
                {

                    switch (btnSortingMethod.Text)
                    {
                        case "Quicksort":
                            quicksort(array, 0, array.Length - 1, sortingSpeed);
                            break;
                        case "Bubblesort":
                            bubblesort(array, sortingSpeed);
                            break;
                        case "Insertion sort":
                            insertionSort(array, sortingSpeed);
                            break;
                        case "Merge sort":
                            mergeSort(array, size, sortingSpeed);
                            break;
                        default:
                            MessageBox.Show("Pick a sorting algorithm!");
                            break;
                    }
                    this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                    {
                        drawArray(array);
                        pbArrayDisplay.Refresh();
                        btnSort.Enabled = true;
                        btnStop.Enabled = false;
                        btnPause.Enabled = false;
                        tbArraySize.Enabled = true;
                        tbSortingSpeed.Enabled = true;
                        btnSortingMethod.Enabled = true;

                        sorting = false;
                    });
                });
                thread.Start();
            }
        }

        private void drawArray(int[] Arr)
        {
            arrayImage = new Bitmap(pbArrayDisplay.Width, pbArrayDisplay.Height);
            using (Graphics g = Graphics.FromImage(arrayImage))
            {
                g.FillRectangle(Brushes.White, new Rectangle(Point.Empty, pbArrayDisplay.Size));
                for (int i = 0; i < size; i++)
                {
                    g.FillRectangle(Brushes.Green, new Rectangle(new Point(i*(pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[i] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                }
            }
            pbArrayDisplay.Invalidate();
        }
        private void drawArray(int[] Arr, int ind_i, Brush color)
        {
            arrayImage = new Bitmap(pbArrayDisplay.Width, pbArrayDisplay.Height);
            using (Graphics g = Graphics.FromImage(arrayImage))
            {
                g.FillRectangle(Brushes.White, new Rectangle(Point.Empty, pbArrayDisplay.Size));
         
                for (int i = 0; i < size; i++)
                {
                    if ( i != ind_i)
                        g.FillRectangle(Brushes.Green, new Rectangle(new Point(i * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[i] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                    else
                        g.FillRectangle(color, new Rectangle(new Point(ind_i * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[ind_i] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                }
            }
            pbArrayDisplay.Invalidate();
        }
        private void drawArray(int[] Arr, int ind_i, int ind_j, Brush color_1, Brush color_2)
        {
            arrayImage = new Bitmap(pbArrayDisplay.Width, pbArrayDisplay.Height);
            using (Graphics g = Graphics.FromImage(arrayImage))
            {
                g.FillRectangle(Brushes.White, new Rectangle(Point.Empty, pbArrayDisplay.Size));

                for (int i = 0; i < size; i++)
                {
                    if (i != ind_i && i != ind_j)
                        g.FillRectangle(Brushes.Green, new Rectangle(new Point(i * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[i] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                    else
                    {
                        g.FillRectangle(color_2, new Rectangle(new Point(ind_j * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[ind_j] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                        g.FillRectangle(color_1, new Rectangle(new Point(ind_i * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[ind_i] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                    }
                }
            }
            pbArrayDisplay.Invalidate();
        }
        private void drawArray(int[] Arr, int ind_i, int ind_j, int ind_k, Brush color_1, Brush color_2, Brush color_3)
        {
            arrayImage = new Bitmap(pbArrayDisplay.Width, pbArrayDisplay.Height);
            using (Graphics g = Graphics.FromImage(arrayImage))
            {
                g.FillRectangle(Brushes.White, new Rectangle(Point.Empty, pbArrayDisplay.Size));

                for (int i = 0; i < size; i++)
                {
                    if (i != ind_i && i != ind_j && i != ind_k)
                        g.FillRectangle(Brushes.Green, new Rectangle(new Point(i * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[i] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                    else
                    {                                               
                        g.FillRectangle(color_1, new Rectangle(new Point(ind_i * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[ind_i] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                        g.FillRectangle(color_2, new Rectangle(new Point(ind_j * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[ind_j] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                        g.FillRectangle(color_3, new Rectangle(new Point(ind_k * (pbArrayDisplay.Width / size), 0), new Size((pbArrayDisplay.Width / size), (Arr[ind_k] * pbArrayDisplay.Height / Arr.Max()) - 10)));
                    }
                }
            }
            pbArrayDisplay.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(arrayImage, Point.Empty);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tbArraySize.Maximum = pbArrayDisplay.Width;
            float newSize = sizeToMax * tbArraySize.Maximum;

            if ( (int)newSize != size && newSize >= 10)
            {
                size = (int)newSize;
                tbArraySize.Value = size;
                sizeToMax = (float)size / (float)tbArraySize.Maximum;
                gbArraySize.Text = "Array size: " + size.ToString();
                Random rnd = new Random();
                array = Enumerable.Range(1, size).OrderBy(x => rnd.Next()).ToArray();
            }     

            drawArray(array);  
        }

        private void pbArrayDisplay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(arrayImage, Point.Empty);
        }

        private void pbArrayDisplay_Resize(object sender, EventArgs e)
        {
            pbArrayDisplay.Refresh();
        }

        private void quicksort(int[] Arr, int lowBound, int highBound, int sortingSpeed)
        {
            if (sorting)
            {
                if (lowBound < highBound)
                {
                    int p = partition(Arr, lowBound, highBound, sortingSpeed);
                    quicksort(Arr, lowBound, p, sortingSpeed);
                    quicksort(Arr, p + 1, highBound, sortingSpeed);
                }
            }
        }

        private int partition(int[] Arr, int lowBound, int highBound, int sortingSpeed)
        {
            int pivot = Arr[lowBound + (highBound - lowBound) / 2];
            int i = lowBound;
            int j = highBound;
            int pom;

            Stopwatch sw = new Stopwatch();

            while (i < j && sorting)
            {
                while (pause) ;
                if (!sorting) break;
                while (Arr[i] < pivot)
                {
                    i++;
                    this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                    {
                        drawArray(Arr, i, j, Brushes.Red, Brushes.Red);
                        pbArrayDisplay.Refresh();
                    });
                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                sw.Reset();
                while (Arr[j] > pivot)
                {
                    j--;
                    this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                    {
                        drawArray(Arr, i, j, Brushes.Red, Brushes.Red);
                        pbArrayDisplay.Refresh();
                    });
                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                sw.Reset();
                if (i >= j)
                {
                    return j;
                }

                pom = Arr[i];
                Arr[i] = Arr[j];
                Arr[j] = pom;
                this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                {
                    drawArray(Arr, i, j, Brushes.Red, Brushes.Red);
                    pbArrayDisplay.Refresh();
                });
            }
            return j;
        }

        private void bubblesort(int[] Arr, int sortingSpeed)
        {
            int n = size;
            Stopwatch sw = new Stopwatch();

            while (n > 1 && sorting)
            {
                int new_n = 0;
                for (int i = 1; i < n && sorting; i++)
                {
                    this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                    {
                        drawArray(Arr, i - 1, Brushes.Red);
                        pbArrayDisplay.Refresh();
                    });
                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                    sw.Reset();

                    while (pause) ;
                    if (!sorting) break;

                    if ( Arr[i] < Arr[i - 1] )
                    {
                        int pom = Arr[i];
                        Arr[i] = Arr[i - 1];
                        Arr[i - 1] = pom;
                        new_n = n;
                    }
                }
                n = new_n;
            }
        }

        private void insertionSort(int[] Arr, int sortingSpeed)
        {
            Stopwatch sw = new Stopwatch();

            for (int i = 1; i < size && sorting; i++)
            {
                int j = i;
                while ( j > 0 && Arr[j - 1] > Arr[j] && sorting)
                {                   
                    this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                    {
                        drawArray(Arr, j, Brushes.Red);
                        pbArrayDisplay.Refresh();
                    });
                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                    sw.Reset();

                    while (pause) ;
                    if (!sorting) break;

                    int pom = Arr[j];
                    Arr[j] = Arr[j - 1];
                    Arr[j - 1] = pom;
                    j--;

                    
                }
            }
        }

        private void mergeSort(int[] Arr, int arrSize, int sortingSpeed)
        {
            int[] tmpArr = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
                tmpArr[i] = Arr[i];

            for ( int width = 1; width < arrSize && sorting; width *= 2)
            {
                for ( int i = 0; i < arrSize; i += 2*width )
                {
                    merge(Arr, tmpArr, i, min(i + width, arrSize), min(i + 2 * width, arrSize), sortingSpeed);
                }
                for (int ind = 0; ind < arrSize; ind++)
                    Arr[ind] = tmpArr[ind];
            }
        }

        private void merge(int[] Arr1, int[] Arr2, int iLeft, int iRight, int iEnd, int sortingSpeed)
        {
            int i = iLeft;
            int j = iRight;
            Stopwatch sw = new Stopwatch();

            for ( int k = i; k < iEnd && sorting; k++ )
            {
                while (pause) ;
                if (!sorting) break;
                if ( i < iRight && ( j >= iEnd || Arr1[i] <= Arr1[j] ) )
                {
                    for(int h = i - 1; h > k; h--)
                    {
                        Arr2[h] = Arr2[h - 1];
                    }                    
                    Arr2[k] = Arr1[i++];
                    this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                    {
                        drawArray(Arr2, k, min(j, Arr1.Length - 1), Brushes.Red, Brushes.Red);
                        pbArrayDisplay.Refresh();
                    });
                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                else
                {          
                    for(int h = j; h > k; h--)
                    {
                        Arr2[h] = Arr2[h - 1];
                    }
                    Arr2[k] = Arr1[j++];
                    this.pbArrayDisplay.Invoke((MethodInvoker)delegate
                    {
                        drawArray(Arr2, k, min(j, Arr1.Length - 1), Brushes.Red, Brushes.Red);
                        pbArrayDisplay.Refresh();
                    });
                    sw.Start();
                    while (true)
                        if (sw.ElapsedMilliseconds > sortingSpeed) break;
                }
                sw.Reset();
            }
        }
        
        private int min(int x, int y)
        {
            return (x < y) ? x : y;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            tbArraySize.Enabled = true;
            tbSortingSpeed.Enabled = true;
            btnSortingMethod.Enabled = true;

            pause = false;
            sorting = false;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnSort.Enabled = true;
            btnStop.Enabled = true;
            btnPause.Enabled = false;
            tbArraySize.Enabled = false;
            tbSortingSpeed.Enabled = false;

            pause = true;
        }
    }
}
