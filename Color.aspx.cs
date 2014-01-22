using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing;




public partial class Color : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //Color color = Color.CreateHtmlTextWriterFromType("#AC55EE");

        	

       
        //Color color = (Color)ColorConverter.ConvertFromString("#AC55EE");

        //// or with alpha channel
        //Color color = (Color)ColorConverter.ConvertFromString("#FFAC55EE");

        ////string sColor = Request.QueryString["color"]; // sColor is now #AA4643
        ////Int32 iColorInt = Convert.ToInt32(sColor.Substring(1), 16);
        ////Color curveColor = System.Drawing.Color.FromArgb(iColorInt); 

        ///////(Color)System.Windows.Media.ColorConverter.ConvertFromString("#FF0348");
        System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#2088C1");

        //Color col = ColorConverter.ConvertFromString("#2088C1") as Color;

    }

    protected System.Drawing.Color setButtonColor(object HexCode)
    {
        return System.Drawing.Color.FromName(HexCode.ToString());
    }




    public static string ToHtml(System.Drawing.Color color)
    {
        if (System.Drawing.Color.Transparent == color)
            return "Transparent";
        return string.Concat("#", (color.ToArgb() & 0x00FFFFFF).ToString("X6"));
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
       


        //ColorPickerExtender1.Color = DirectCast(ColorConverter.ConvertFromString("#D8E0A627"), Color);

        //Color color = (Color)ColorConverter.ConvertFromString("#FFDFD991");


        //Color col = ColorConverter.ConvertFromString("#FFDFD991") as Color;

        //string colorcode = "#FFFFFF00";
        //int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
        //Color clr = Color.FromArgb(argb);
        
        
        
        
        
        
        
        
        
        
        
        
        /// TextBox1.Text=ToHtml(System.Drawing.Color color);
        
        
        // System.Drawing.Color myColor = System.Drawing.Color.FromArgb(TextBox1.Text);
        // TextBox1.Text=Convert.ToString(System.Drawing.Color myColor);


        //if (System.Drawing.Color.Transparent ==C)
        //    //return "Transparent";
        //return string.Concat("#", (Color.ToArgb() & 0x00FFFFFF).ToString("X6"));

        //System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#2088C1");

        //Color col = ColorConverter..ConvertFromString("#2088C1") as Color;
        //TextBox1.Text = "#0000EE";

        //GetColor(string colorCode);

      // DisplayKnownColors();



        System.Drawing.Color divBackColor = System.Drawing.Color.FromName(TextBox1.Text); 
         

       


    }

    //private KnownColor GetColor(string colorCode)
    //{
        
    //    Color color = GetSystemDrawingColorFromHexString(colorCode);
    //    return color.GetColor();
    //}



    //private void DisplayKnownColors(PaintEventArgs e)
    //{
    //    this.Size = new Size(650, 550);

    //    // Get all the values from the KnownColor enumeration.
    //    System.Array colorsArray = Enum.GetValues(typeof(KnownColor));
    //    KnownColor[] allColors = new KnownColor[colorsArray.Length];

    //    Array.Copy(colorsArray, allColors, colorsArray.Length);

    //    // Loop through printing out the values' names in the colors 
    //    // they represent.
    //    float y = 0;
    //    float x = 10.0F;

    //    for (int i = 0; i < allColors.Length; i++)
    //    {

    //        // If x is a multiple of 30, start a new column.
    //        if (i > 0 && i % 30 == 0)
    //        {
    //            x += 105.0F;
    //            y = 15.0F;
    //        }
    //        else
    //        {
    //            // Otherwise, increment y by 15.
    //            y += 15.0F;
    //        }

    //        // Create a custom brush from the color and use it to draw
    //        // the brush's name.
    //        SolidBrush aBrush =
    //            new SolidBrush(Color.FromName(allColors[i].ToString()));
    //        e.Graphics.DrawString(allColors[i].ToString(),
    //            this.Font, aBrush, x, y);

    //        // Dispose of the custom brush.
    //        aBrush.Dispose();
    //    }

   // }
}
  

