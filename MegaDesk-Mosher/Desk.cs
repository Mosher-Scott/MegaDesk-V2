
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk_Mosher
{
    class Desk
    {
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        public const int BASEPRICE = 200;

        public double deskWidth { get; set; }
        public double deskDepth { get; set; }
        public int numDrawers { get; set; }
        public string surfaceMaterial { get; set; }
        public int rushOption { get; set; }

        public Desk()
        {

        }

        public Desk(double userWidth, double userDepth, int userDrawers, string userMaterial, int userRushOption)
        {
            deskWidth = userWidth;
            deskDepth = userDepth;
            numDrawers = userDrawers;
            surfaceMaterial = userMaterial;
            rushOption = userRushOption;
        }

        public enum SurfaceMaterials
        {
            Laminate = 100,
            Oak = 200,
            Rosewood = 300,
            Veneer = 125,
            Pine = 50
        }

        // Calculates the entire surface area
        public double getDeskSurfaceArea()
        {
            return this.deskWidth * this.deskDepth;
        }

        // Returns the cost above the base price if the surface area is greater than 1000 sq in
        public double getSurfaceAreaCost()
        {
            double cost = 0;
            double surfaceArea = getDeskSurfaceArea(); 

            if (surfaceArea > 1000)
            {
                cost = surfaceArea - 1000;
            }

            return cost;
        }

        // Returns the cost of drawers, based on how many the client orders
        public double getDrawerCost()
        {
            return this.numDrawers * 50;
        }

        // Gets the cost of the surface materials the client wants
        public double getSurfaceMaterialCost()
        {
            double cost = 0;

            switch (this.surfaceMaterial)
            {
                case "Oak":
                    cost = (int)SurfaceMaterials.Oak;
                    break;

                case "Laminate":
                    cost = (int)SurfaceMaterials.Laminate;
                    break;

                case "Pine":
                    cost = (int)SurfaceMaterials.Pine;
                    break;

                case "Rosewood":
                    cost = (int)SurfaceMaterials.Rosewood;
                    break;

                case "Veneer":
                    cost = (int)SurfaceMaterials.Veneer;
                    break;
            }

            return cost;
        }

        //Access DeskQuote to obtain rushOrder
        DeskQuote newQuote = new DeskQuote(quoteFirstName, quoteLastName, quoteDate, deskQuoteTotal, quoteDesk);
        //TODO: Figure out how to not include these but grab method from DeskQuote. Maybe
        // move getRushOrderPrice() to DeskQuote?
        
        private static string quoteFirstName;
        private static string quoteLastName;
        private static string quoteDate;
        private static double deskQuoteTotal;
        private static Desk quoteDesk;

        // Gets the rush order options based on desk size
        public double getRushOrderPrice()
        {
            int[,] rushOrderGrid = newQuote.GetRushOrder();
            
            double price = 0;
            double surfaceArea = getDeskSurfaceArea();

            if (surfaceArea < 1000)
            {
                if (this.rushOption == 3)
                {
                    price = rushOrderGrid[0, 0];

                } else if (this.rushOption == 5)
                {
                    price = rushOrderGrid[1, 0];
                } else if (this.rushOption == 7)
                {
                    price = rushOrderGrid[2, 0];
                }
            }

            else if (surfaceArea > 1000 && surfaceArea < 2000)
            {
                if (this.rushOption == 3)
                {
                    price = rushOrderGrid[0, 1];
                }
                else if (this.rushOption == 5)
                {
                    price = rushOrderGrid[1, 1];
                }
                else if (this.rushOption == 7)
                {
                    price = rushOrderGrid[2, 1];
                }
            }

            else
            {
                if (this.rushOption == 3)
                {
                    price = rushOrderGrid[0, 2];
                }
                else if (this.rushOption == 5)
                {
                    price = rushOrderGrid[1, 2];
                }
                else if (this.rushOption == 7)
                {
                    price = rushOrderGrid[2, 2];
                }
            }

            return price;
        }

        public double getTotalCost()
        {
            return Desk.BASEPRICE + this.getSurfaceAreaCost() + this.getDrawerCost() + this.getSurfaceMaterialCost() + this.getRushOrderPrice();
        }

       

    }
}
