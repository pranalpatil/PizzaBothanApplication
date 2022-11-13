namespace PizzaBothanApplication
{
    public partial class PizzaBothanApplications : Form
    {

        private void servers_name_label_Click(object sender, EventArgs e)
        {

        }

        private void starts_button_Click(object sender, EventArgs e)
        {
            this.Text=servername_input_textbox.Text + " @ Table " + tableno_Input_textbox.Text;
            //Required field 
            if (string.IsNullOrEmpty(servername_input_textbox.Text))
            {
                MessageBox.Show("Please Mention Server Name", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                servername_input_textbox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tableno_Input_textbox.Text))
            {
                MessageBox.Show("Please Mention Table Number", "Hello", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tableno_Input_textbox.Focus();
                return;
            }
            menu_groupbox.Visible= true;
            buttons_panel.Visible= true;
            bottomlogo_picturebox.Visible= true;
            background_panel.Visible= false;
            logo_homepage_picturebox.Visible= false;
            

        }

        private void orders_button_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal d1 = 2.99m;
                Decimal d2 = 3.99m;
                Decimal d3 = 4.99m;
                Decimal d4 = 5.99m;



                Decimal HamPizza, PepperoniPizza, PineapplePizza, Calzoni, TotalAmount;
                HamPizza= Decimal.Parse(hampizza_input_textbox.Text);
                PepperoniPizza= Decimal.Parse(pepperoni_input_textbox.Text);
                PineapplePizza= Decimal.Parse(pineapplepizza_input_textbox.Text);
                Calzoni= Decimal.Parse(calzoni_input_textbox.Text);

                HamPizza=HamPizza * d1;
                PepperoniPizza=PepperoniPizza * d2;
                PineapplePizza=PineapplePizza * d3;
                Calzoni=Calzoni * d4;

                TotalAmount= HamPizza+PepperoniPizza+PineapplePizza+Calzoni;

                TableReceiptsSummaryDataLabel.Text=TotalAmount.ToString();
            }
            catch
            {
                MessageBox.Show("enter correct data");
            }

            summary_data_groupbox.Visible= true;
            company_summary_group.Visible = false;
            string name = servername_input_textbox.Text;
            ServerNameOrderSummartlabel.Text=name;

        }

        private void summarys_button_Click(object sender, EventArgs e)
        {
            company_summary_group.Visible= true;
        }

        private void exits_button_Click(object sender, EventArgs e)
        {
            //Application Exit button.
            DialogResult iExit;
            iExit = MessageBox.Show("Are you Sure?", "Close PizzaBothan Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clears_button_Click(object sender, EventArgs e)
        {
            background_panel.Visible=true;
            background_panel.Focus();
            logo_homepage_picturebox.Visible= true;
            menu_groupbox.Visible = false;
            buttons_panel.Visible= false;
            bottomlogo_picturebox.Visible= false;
            company_summary_group.Visible = false;
            summary_data_groupbox.Visible= false;

            clears();

        }      
        void clears()
        {
            servername_input_textbox.Clear();
            tableno_Input_textbox.Clear();
            hampizza_input_textbox.Clear();
            pepperoni_input_textbox.Clear();
            pineapplepizza_input_textbox.Clear();
            calzoni_input_textbox.Clear();
            servername_input_textbox.Focus();


        }

        private void ClearButtonToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        
    }
}