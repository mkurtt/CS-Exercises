using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonGameApp1
{
    public enum Layers
    {
        layer1, //top
        layer2, //mid
        layer3  //bot
    }

    class Tile : Button
    {
        public int ID { get; set; }

        private bool isSelected;
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                if (value)
                {
                    this.BackColor = Color.Magenta;
                }
                else
                {
                    this.Layer = this.layer;
                }
                
                isSelected = value;
            }
        }

        public List<Tile> OnTop { get; set; }

        private Layers layer;
        public Layers Layer
        {
            get
            {
                return layer;
            }
            set
            {
                switch (value)
                {
                    case Layers.layer1:
                        BackColor = Color.Green;
                        break;
                    case Layers.layer2:
                        BackColor = Color.Cyan;
                        break;
                    case Layers.layer3:
                        BackColor = Color.Red;
                        break;
                    default:
                        break;
                }
                layer = value;
            }
        }

        private string Type;
        public string type {
            get
            {
                return Type;
            }
            set
            {
                this.Text = value;
                Type = value;
            }
        }

        public Tile(Layers layer)
        {
            this.Font = new Font("Arial", 30, FontStyle.Bold);
            this.Layer = layer;
            OnTop = new List<Tile>();
            Width = 100;
            Height = 120;
        }
    }
}
