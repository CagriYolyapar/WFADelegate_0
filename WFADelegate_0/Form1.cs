using WFADelegate_0.Models;

namespace WFADelegate_0
{
    public partial class Form1 : Form
    {

        //Delegate : Delegate birden fazla metodu veya bir metodu kapsülleyen ve tetiklemenizi saglayan bir yapıdır...  

        //Action
        //Predicate
        //Func


        delegate void TestDelegate();

        delegate int DenemeDelegate(int number);


        delegate void AkademikGorev();


        delegate void ProjeGorevi();

        public void MufredatHazirla()
        {

        }

        public void DersAnlat()
        {

        }

        public void EtutVer()
        {

        }


        public void ProjeYaz()
        {

        }

        public void KurumsalEgitimVer()
        {

        }

        public void MerkeziDestekver()
        {

        }

        public void Selamla()
        {
            MessageBox.Show("Hello World");
        }

        public void Sor()
        {
            MessageBox.Show("Nasılsın?");
        }


        public int KareAl(int number)
        {
            return number * number;
        }

        public int YarisiniAl(int number)
        {
            return number / 2;
        }


        public Form1()
        {
            InitializeComponent();

        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            #region DelegateNotlari


            TestDelegate testDelegate = new(Selamla); //BUrada dikkat edin : Selamla isimli metodu cagırmıyoruz...O yüzden parantezlerini vermiyoruz...Metodu bir yapı olarak Delegate'e veriyoruz(ona ekliyoruz)
            testDelegate += Sor; //Eger olusturulan bir Delegate'e baska bir metot daha eklemek isterseniz += operatorunu kullanırsınız...Böylece multicast delegate yapmıs olduk...Delegate will execute the methods in order!!!
            DenemeDelegate denemeDelegate = new(KareAl);
            denemeDelegate += YarisiniAl;



            //testDelegate.Invoke();

            Text = denemeDelegate.Invoke(4).ToString();


            Egitmen<AkademikGorev> egt = new Egitmen<AkademikGorev>();

            Egitmen<ProjeGorevi> egt2 = new Egitmen<ProjeGorevi>();
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AkademikGorev akademikGorev = new(DersAnlat);
            akademikGorev += MufredatHazirla;
            akademikGorev += EtutVer;

            ProjeGorevi pg = new(KurumsalEgitimVer);
            pg += ProjeYaz;
            pg += MerkeziDestekver;
        }
    }
}
