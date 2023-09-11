namespace Delegate_ve_Event_İlişkisi
{
    public partial class Form1 : Form
    {
        delegate int Del(int x);
        delegate void Yaz(string metin);
        public Form1()
        {
            InitializeComponent();

            //this.Load += Form1_Load;
            //this.DoubleClick += Form1_DoubleClick;

            // Event'ler arka planda birer delegate'dir.

            //Del myDelegate = x => x * x;
            //int y = myDelegate(3);
            //MessageBox.Show(y.ToString());

            //Yaz yaz = x => MessageBox.Show(x);
            //yaz("Merhaba Yaz!");

            //this.Click += Form1_Click;

            // kendimiz oluşturusak:
            //this.Click += (s, e) => { MessageBox.Show(((MouseEventArgs)e).Location.ToString()); };
            
            // Dinamik Nesne ve Event Kullanımı

            Button btn = new Button();
            btn.Text = "Tıkla!";
            btn.Name = "btnTıkla";
            btn.Width = 200;
            btn.Height = 50;
            btn.Left = btn.Width + 5;
            btn.Click += delegate (object sender, EventArgs e)
            {
                // Gösterilmesi gereken mesaj olarak, sender ile gelen nesnenin kendisini butona cast ettik. 
                // Obje olarak geliyordu bunun butona deönüştürülmesi gerekiyordu. Ve bunun textini aldık (tıkla).
                string mesaj = (sender as Button).Text; 
                MessageBox.Show(mesaj);
            };
            this.Controls.Add(btn);

            // Kendimiz el ile tetiklemek istersek: 

            Button button1 = new Button();
            button1.Click += delegate
            {
                MessageBox.Show("Tıklandı!");
            };
        }

        //// Kullandığımız nesnenin kendisi sender tipinde gelir.     
        //private void Form1_Click(object? sender, EventArgs e) 
        //{
        //    MessageBox.Show(((MouseEventArgs)e).Location.ToString());
        //}

        //private void Form1_DoubleClick(object? sender, EventArgs e)
        //{
        //    MessageBox.Show("Merhaba!");
        //}

        //private void Form1_Load(object? sender, EventArgs e)
        //{
        //   // MessageBox.Show("Merhaba!");
        //}
    }
}