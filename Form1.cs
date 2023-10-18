namespace checkConnectionMysql
{
    public partial class Form1 : Form
    {
        Data.Connection con = new Data.Connection();
        public Form1()
        {
            InitializeComponent();
            IblSuccess.Visible = false;
            IblError.Visible = false;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                Data.Connection.dataSource();
                con.connOpen();
                IblSuccess.Visible = true;
                IblError.Visible = false;
                con.connClose();
            }
            catch (Exception)
            {
                IblError.Visible = true;
                IblSuccess.Visible = false;
                con.connClose();
            }   
            finally
            {
                con.connClose();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}