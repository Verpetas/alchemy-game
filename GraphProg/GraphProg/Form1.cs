using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Unsplasharp;

namespace GraphProg
{
    public partial class Form1 : Form
    {
        public Dictionary<string, List<string>> combos;
        public List<Label> items = new List<Label>();
        public List<PictureBox> pics = new List<PictureBox>();

        public Form1(string location)
        {
            InitializeComponent();
            MaximizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            JObject combosJson = JObject.Parse(File.ReadAllText(location));
            string combosStr = combosJson.ToString(Formatting.None);

            combos = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(combosStr);


            int x = 0;
            int y = 0;
            bool onePIcked = false;

            foreach (KeyValuePair<string, List<string>> kvp in combos)
            {
                Label label = new Label();
                label.Font = new Font("Arial", 11, FontStyle.Bold);
                label.Name = kvp.Key;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Dock = DockStyle.Fill;
                //label.Enabled = false;
                label.BackColor = Color.Wheat;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.BorderStyle = BorderStyle.FixedSingle;

                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = kvp.Key;
                //pictureGetter(pictureBox);
                pictureBox.Size = new Size(150, 75);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                tableLayoutPanel1.Controls.Add(pictureBox, x, y);
                pics.Add(pictureBox);

                if (kvp.Value[0] != null && kvp.Value[1] != null)
                {
                    label.Text = "";
                    label.Enabled = false;
                }
                else
                {
                    label.Text = kvp.Key;
                    pictureGetter(pictureBox, true);
                }

                label.Click += delegate
                {
                    if (onePIcked)
                    {
                        item2.Text = label.Text;
                        pics.Where(e => e.Name == kvp.Key).ToList().ForEach(e => secondItemPic.Image = e.Image);
                    }
                    else
                    {
                        item1.Text = label.Text;
                        pics.Where(e => e.Name == kvp.Key).ToList().ForEach(e => firstItemPic.Image = e.Image);
                    }
                        
                    onePIcked = !onePIcked;
                };

                tableLayoutPanel1.Controls.Add(label, x, y+1);
                items.Add(label);

                x++;

                if (x > 9)
                {
                    x = 0;
                    y += 2;
                }

            }

        }

        async void pictureGetter(PictureBox img, bool init = false)//PictureBox imageBox)
        {
            Random rnd = new Random();
            //Console.WriteLine("///" + img.Name + "///");

            var client = new UnsplasharpClient("yqVgVYnt5pdzV1Fcmov3QnCSn930Uj-kscIrUJaikg8");
            var photosFound = await client.SearchPhotos(img.Name);
            string photosJson = JsonConvert.SerializeObject(photosFound, Formatting.Indented);
            //Console.WriteLine(photosJson);//.GetType());
            var photos = (JArray)JsonConvert.DeserializeObject(photosJson);

            //Console.WriteLine(photos[0]["Urls"]["Thumbnail"]);//.GetType());

            try
            {
                dynamic request;

                if (photos.Count < 10)
                {
                    request = WebRequest.Create(photos[rnd.Next(1, photos.Count)]["Urls"]["Thumbnail"].ToString());
                }
                else
                {
                    request = WebRequest.Create(photos[rnd.Next(1, 10)]["Urls"]["Thumbnail"].ToString());
                }

                var response = request.GetResponse();
                var stream = response.GetResponseStream();

                Image image = Image.FromStream(stream);

                img.Image = image;
                img.SizeMode = PictureBoxSizeMode.StretchImage;

                if (!init)
                {
                    comboPicture.Image = image;
                    comboPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Picture for " + img.Name + " out of range.");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;

            Console.WriteLine("Item1: " + item1.Text + ", item2: " + item2.Text);

            foreach (KeyValuePair<string, List<string>> kvp in combos)
            {
                if((item1.Text == kvp.Value[0] && item2.Text == kvp.Value[1]) || (item1.Text == kvp.Value[1] && item2.Text == kvp.Value[0]))
                {
                    itemCombo.Text = kvp.Key;
                    itemCombo.ForeColor = Color.Green;
                    youGotLabel.Visible = true;
                    items.Where(x => x.Name == kvp.Key).ToList().ForEach(x =>
                    {
                        //x.ForeColor = Color.Black;
                        x.Enabled = true;
                        x.Text = x.Name;
                    });         

                    //pics.Where(x => x.Name == kvp.Key).ToList().ForEach(x => Console.WriteLine(":::" + x.Name + ":::"));
                    pics.Where(x => x.Name == kvp.Key).ToList().ForEach(x =>
                    {
                        pictureGetter(x);
                    });
                    

                    found = true;
                }
            }

            if(!found)
            {
                itemCombo.Text = "No combo";
                itemCombo.ForeColor = Color.Red;
                comboPicture.Image = null;
                youGotLabel.Visible = false;
            }

            found = false;

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void item1_Click(object sender, EventArgs e)
        {

        }

        private void comboPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
