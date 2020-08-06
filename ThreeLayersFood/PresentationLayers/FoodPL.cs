using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreeLayersFood.DataAccessLayers;
using ThreeLayersFood.BusinessLogicLayers;
namespace ThreeLayersFood
{
    public partial class FoodPL : Form
    {
        FoodBLL foodbll = new FoodBLL();
        public FoodPL()
        {
            InitializeComponent();
            cmb_Unit.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void FoodPL_Load(object sender, EventArgs e)
        {

            dataGridView.DataSource = foodbll.Load_Item();
        }

        private void btn_NewItem_Click(object sender, EventArgs e)
        {
            Item food = new Item();
            food.Name_Food = tbx_Name.Text;
            food.Detail = tbx_Detail.Text;
            food.Price = Int32.Parse(tbx_Price.Text);
            food.Quantity =Int32.Parse(tbx_Qualntity.Text);
            food.Seller_ID = tbx_Seller.Text;
            food.Unit = cmb_Unit.SelectedItem.ToString();
           
            if (foodbll.Add_new(food))
            {
                dataGridView.DataSource = foodbll.Load_Item();
                MessageBox.Show("Complete", "Result", MessageBoxButtons.OK);
            } 
            else MessageBox.Show("Fail", "Result", MessageBoxButtons.OK);

        }

        private void tbx_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbx_Qualntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                tbx_ID.Text = row.Cells[0].Value.ToString();
                tbx_Name.Text = row.Cells[1].Value.ToString();
                tbx_Detail.Text = row.Cells[2].Value.ToString();
                tbx_Price.Text = row.Cells[3].Value.ToString();
                tbx_Qualntity.Text = row.Cells[4].Value.ToString();               
                cmb_Unit.SelectedItem = row.Cells[5].Value.ToString();
                tbx_Seller.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Item food = new Item();
            food.Food_ID = tbx_ID.Text;
            food.Name_Food = tbx_Name.Text;
            food.Detail = tbx_Detail.Text;
            food.Price = Int32.Parse(tbx_Price.Text);
            food.Quantity = Int32.Parse(tbx_Qualntity.Text);
            food.Seller_ID = tbx_Seller.Text;
            food.Unit = cmb_Unit.SelectedItem.ToString();

            if (foodbll.Update_Food(food))
            {
                dataGridView.DataSource = foodbll.Load_Item();
                MessageBox.Show("Complete", "Result", MessageBoxButtons.OK);
            }
            else MessageBox.Show("Fail", "Result", MessageBoxButtons.OK);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Item food = new Item();
            food.Food_ID = tbx_ID.Text;
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this food?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (foodbll.Delete_Food(food))
                {
                    dataGridView.DataSource = foodbll.Load_Item();
                    MessageBox.Show("Delete complete", "Result", MessageBoxButtons.OK);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
           
           
        }
    }
}
