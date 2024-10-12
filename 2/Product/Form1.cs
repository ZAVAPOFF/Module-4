using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class Form1 : Form
    {
        private List<IProduct> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<IProduct>
        {
            new Apple(4.23m, 50),
            new Banana(7.96m, 75),
            new Bread(2m,15),
            new Yogurt(3m,20),
            new Nuts(1.30m,100),
            new Fanta(2.80m,120),
            new Cookies(0.64m,35),
            new Water(1m,150),
            new BubbleGum(1.33m,70),
            new SunflowerSeeds(3,20),
            new Croissant(1.5m,40)
        };
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            foreach (var product in products)
            {
                ListProducts.Items.Add($"Продукт: {product.GetType().Name}, Стоимость: {product.GetPrice()}, Количество: {product.GetStock()}");
            }
        }
    }
}
