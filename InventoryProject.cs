using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject
{

    class Program
    {
        struct ItemData
        {
            public int itemIDNo;
            public string sDescription;
            public double dblPricePerItem;
            public int iQuantityOnHand;
            public double dblOurCostPerItem;
            public double dblValueOfItem;
        }
        static void Main()
        {

            ItemData[] itemdata = new ItemData[50];
            var icount = 0; //Item counter
            

            while (true)
            {

                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Change an item");
                Console.WriteLine("3. Delete an item");
                Console.WriteLine("4. List all items in the database");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Please make a selection:");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine();

                switch (input)
                {
                    case 1:
                        //Add an item
                        Item:
                        Console.Write("Enter Item Number:");
                        int ItemNumber = int.Parse(Console.ReadLine());
                        if (ItemNumber > 999999)
                        {
                            Console.WriteLine("Item number is too large. (0-999999)");
                            goto Item;
                        }
                        itemdata[icount].itemIDNo = ItemNumber;

                        //Item description
                        Description:
                        Console.Write("Enter Item Description:");
                        string ItemDescription = Console.ReadLine();
                        if (ItemDescription.Length > 19 )
                        {
                            Console.WriteLine("Item description is too long. Please limit to 19 characters.");
                            goto Description;
                        }
                        itemdata[icount].sDescription = ItemDescription;

                        //Price per item
                        ItemPrice:
                        Console.Write("Enter Item Price:");
                        double ItemPrice = double.Parse(Console.ReadLine());
                        if (ItemPrice > 99999)
                        {
                            Console.WriteLine("Item price to high.");
                            goto ItemPrice;
                        }
                        itemdata[icount].dblPricePerItem = ItemPrice;

                        //Quantity on hand
                        Console.Write("Enter Quantity on Hand:");
                        int ItemQuantity = int.Parse(Console.ReadLine());
                        itemdata[icount].iQuantityOnHand = ItemQuantity;

                        //Our cost per item
                        Console.Write("Enter Our Cost For Item:");
                        double ItemCost = double.Parse(Console.ReadLine());
                        itemdata[icount].dblOurCostPerItem = ItemCost;
                        Console.WriteLine();

                        //Value of item(price * quantity on hand)
                        double ItemValue = ItemPrice * ItemQuantity;
                        itemdata[icount].dblValueOfItem = ItemValue;
                        Console.WriteLine("-----------------------------------------------------");
                        Console.WriteLine("Item has been added");
                        Console.WriteLine("-----------------------------------------------------");
                        icount = icount + 1;
                        break;
                    case 2:
                        {
                            //Change an item
                            Console.Write("Please enter an item ID No:");
                            string strchgid = Console.ReadLine();
                            int chgid = int.Parse(strchgid);
                            bool fFound = false;

                            for (int x = 0; x < icount; x++)
                            {
                                if (itemdata[x].itemIDNo == chgid)
                                {
                                    fFound = true;
                                    //Item description
                                    Console.Write("Enter New Item Description:");
                                    string NewItemDescription = Console.ReadLine();
                                    itemdata[x].sDescription = NewItemDescription;

                                    //Price per item
                                    Console.Write("Enter Item Price:");
                                    double NewItemPrice = double.Parse(Console.ReadLine());
                                    itemdata[x].dblPricePerItem = NewItemPrice;

                                    //Quantity on hand
                                    Console.Write("Enter Quantity on Hand:");
                                    int NewItemQuantity = int.Parse(Console.ReadLine());
                                    itemdata[x].iQuantityOnHand = NewItemQuantity;

                                    //Our cost per item
                                    Console.Write("Enter Our Cost For Item:");
                                    double NewItemCost = double.Parse(Console.ReadLine());
                                    itemdata[x].dblOurCostPerItem = NewItemCost;
                                    Console.WriteLine();

                                    //Value of item(price * quantity on hand)
                                    double NewItemValue = NewItemPrice * NewItemQuantity;
                                    itemdata[x].dblValueOfItem = NewItemValue;
                                    Console.WriteLine("-----------------------------------------------------");
                                    Console.WriteLine("Item has been modified");
                                    Console.WriteLine("-----------------------------------------------------");
                                }
                            }

                            if (!fFound) // and if not found
                            {
                                Console.WriteLine("Item {0} not found", chgid);
                            }

                            break;
                        }
                    case 3:
                        {
                            //Delete an item
                            Console.Write("Please enter an item ID No:");
                            string strdeleteid = Console.ReadLine();
                            int deleteid = int.Parse(strdeleteid);
                            bool DeleteFound = false;

                            for (int x = 0; x < icount; x++)
                            {
                                if (itemdata[x].itemIDNo == deleteid)
                                {
                                    DeleteFound = true;
                                    for (; x < icount; x++)
                                    {
                                        icount--;
                                        for (; x < icount; x++)
                                        {
                                            itemdata[x] = itemdata[x + 1];
                                        }
                                    }

                                    ItemData[] newArray = new ItemData[50];

                                    for (int index = 0; index < icount; index++)
                                    {
                                        newArray[index] = itemdata[index];
                                    }

                                    
                                    itemdata = newArray;
                                }
                            }
                            if (!DeleteFound) 
                            {
                                Console.WriteLine("Item {0} not found", deleteid);
                            }
                            break;
                        }
                    case 4:
                        {
                            //List all items in the database

                            Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                            Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                            for (int i = 0; i < icount; i++)
                            {
                                {
                                    Console.Write("{0,5}  ", i);
                                    Console.Write("{0,6}  ", itemdata[i].itemIDNo);
                                    Console.Write("{0,-19}   ", itemdata[i].sDescription);
                                    Console.Write("{0,5}   ", itemdata[i].dblPricePerItem);
                                    Console.Write("{0,2}   ", itemdata[i].iQuantityOnHand);
                                    Console.Write("{0,3}   ", itemdata[i].dblOurCostPerItem);
                                    Console.Write("{0,4}   ", itemdata[i].dblValueOfItem);
                                    Console.WriteLine();
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            //Exit
                            Console.Write("Are you sure you want to exit? (1:Yes 2:No):");
                            int exitinput = int.Parse(Console.ReadLine());
                            if (exitinput == 1)
                            {
                                Environment.Exit(0);
                            }
                            break;
                        }
                     default:
                        {
                            Console.WriteLine("That is not a valid selection.");
                            break;
                        }
                }
                Console.WriteLine();
            }


        }
    }
}
