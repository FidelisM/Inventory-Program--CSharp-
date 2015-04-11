/*Name: Fidelis Msacky
  Course: CMPS4143 - Contemporary Prog. Lang.
  Prof: C. Stringfellow 
  Program 7: Inventory Program
  Date: 11/15/2014
 
  Summary: This program utilises FIlestrem to read and 
           write to file, menus, list boxed and a MDI*/

using System;

[Serializable]
public class Record
{
    public int id;
    public int quantity;
    public double price;
    public string name;

    public Record(): this(0, 0, 0F, "")
    {
    }

    // overloaded constructor sets members to parameter values
    public Record(int idvalue, int quantityvalue, double pricevalue, string namevalue)
    {
        id = idvalue;
        quantity = quantityvalue;
        price = pricevalue;
        name = namevalue;
    } // end constructor

    // property ID
    public int ID
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    } 

    // property Quantity
    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            quantity = value;
        }
    } 

    // property Price
    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

    // property Name
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}