using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPI_2048
{
    class Graphics
    {
        public void display(int[,] grid, System.Windows.Forms.DataGridView field)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] != 0) field[i, j].Value = grid[i, j];
                    else field[i, j].Value = "";
                    switch (grid[i, j])
                    {
                        case 0:
                            field[i, j].Style.BackColor = System.Drawing.Color.OldLace;

                            break;
                        case 2:
                            field[i, j].Style.BackColor = System.Drawing.Color.PapayaWhip;
                            break;
                        case 4:
                            field[i, j].Style.BackColor = System.Drawing.Color.AntiqueWhite;
                            break;
                        case 8:
                            field[i, j].Style.BackColor = System.Drawing.Color.BlanchedAlmond;
                            break;
                        case 16:
                            field[i, j].Style.BackColor = System.Drawing.Color.Bisque;
                            break;
                        case 32:
                            field[i, j].Style.BackColor = System.Drawing.Color.PeachPuff;
                            break;
                        case 64:
                            field[i, j].Style.BackColor = System.Drawing.Color.NavajoWhite;
                            break;
                        case 128:
                            field[i, j].Style.BackColor = System.Drawing.Color.BurlyWood;
                            break;
                        case 256:
                            field[i, j].Style.BackColor = System.Drawing.Color.Tan;
                            break;
                        case 512:
                            field[i, j].Style.BackColor = System.Drawing.Color.SandyBrown;
                            break;
                        case 1024:
                            field[i, j].Style.BackColor = System.Drawing.Color.Peru;
                            break;
                        case 2048:
                            field[i, j].Style.BackColor = System.Drawing.Color.Chocolate;
                            break;
                    }
                }
        }
        public void graphics_property(System.Windows.Forms.DataGridView field)
        {
            field.ColumnCount = 4;
            field.RowCount = 4;
            for (int i = 0; i < 4; i++)
            {
                field.Columns[i].Width = 75;
                field.Rows[i].Height = 75;
            }
            field.ClearSelection();
        }
    }
}
