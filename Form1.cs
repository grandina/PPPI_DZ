using System.Windows.Forms;

namespace PPPI_2048
{
    public partial class Form1 : Form
    {
        Generator form_generator;
        Graphics form_graphic;
        Core form_core;
        GridMove mover;
        int[,] form_grid;
        public Form1()
        {
            InitializeComponent();
            form_generator = new Generator();
            form_graphic = new Graphics();
            form_core = new Core();
            mover = new GridMove();
            form_grid = new int[4, 4];
            form_graphic.graphics_property(dataGridView1);
            UpdateGrid(2);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    mover.moveDown(ref form_grid);
                    break;
                case Keys.Up:
                    mover.moveUp(ref form_grid);
                    break;
                case Keys.Left:
                    mover.moveLeft(ref form_grid);
                    break;
                case Keys.Right:
                    mover.moveRight(ref form_grid);
                    break;
                case Keys.Escape:
                    Close();
                    break;

            }
            UpdateGrid(1);
            switch (form_core.GameStatus(form_grid))
            {
                case 0:
                    MessageBox.Show("Вы проиграли");
                    break;
                case 2:
                    MessageBox.Show("Вы выиграли");
                    break;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            form_grid = new int[4, 4];
            UpdateGrid(2);
        }
        private void UpdateGrid(int count)
        {
            form_generator.generate(ref form_grid, count);
            form_graphic.display(form_grid, dataGridView1);
        }
    }
}
