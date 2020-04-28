using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncurtadorUrl.Model;
namespace EncurtadorUrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //corta os link para dentro do array
            string[] boxUrlsCortadas = numerosWhats.Text.Split('\n');
            // passa a informação para label de quantos links existe                     
            qtdUrl.Text = Convert.ToString(boxUrlsCortadas.Length);
            string site = "http://abre.ai/";
            Encurtador abreai = new Encurtador();

            //Inicia o chrome driver
            IWebDriver bot = new ChromeDriver();

            for (int i = 0; i < boxUrlsCortadas.Length; i++)
            {
                bot.Navigate().GoToUrl(site);
                Console.WriteLine("Entrando no site.");
                Thread.Sleep(2000);

                //TODO inserir log
                var inputUrl = bot.FindElement(By.XPath("//*[@id='input']/label[1]/input"));
                Console.WriteLine("Inserindo valor no input");
                inputUrl.SendKeys(boxUrlsCortadas[i]);

                Thread.Sleep(2000);
                var botaoSubmit = bot.FindElement(By.CssSelector("input[type='submit']"));
                botaoSubmit.Submit();

                Thread.Sleep(3000);
                //TODO inserir log
                Console.WriteLine("Inserindo valor no programa");
                var linkEncurtado = bot.FindElement(By.Id("encurtado")).GetAttribute("value");
                linksFinais.Text +=  linkEncurtado + "\n";
               // richTextBox1.Text.ite

            }
            bot.Close();
            bot.Dispose();











        }

    }
}
