using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuikSwe.Models;

namespace TuikSwe.Data
{
    public static class TuikRepository
    {
        private static List<Tuik> _tuiks = null;
        
        static TuikRepository()
        {
            _tuiks = new List<Tuik>()
            {
                new Tuik() {
                    Id = 1,
                    Name ="Aggricultural Animal",
                     TableColumnName ="<th>Date</th>" +
                    "<th>Cattle</th>"+
                    "<th>Sheep</th>"+
                    "<th>Goats</th>"+
                    "<th>Total</th>",
                    Description =" <tr>" +
                    "<td>2001</td>" +
                    " <td>10 548 000</td>" +
                    " <td>26 972 000</td>" +
                    "<td>7 022 000</td>" +
                    "<td>44 542 000</td>"+
                    "</tr>"+

                    "<tr>"+
                    " <td>2002</td>" +
                    " <td> 9 803 498</td>" +
                    " <td>25 173 706</td>" +
                    "<td>6 780 094</td>" +
                    "<td>41 757 298</td>"+
                    
                    "<tr>"+
                    " <td>2002</td>" +
                    " <td> 9 803 498</td>" +
                    " <td>25 173 706</td>" +
                    "<td>6 780 094</td>" +
                    "<td>41 757 298</td>"+
                    "</tr>"+

                    "<tr>"+
                    " <td>2003</td>" +
                    " <td>9 788 102</td>" +
                    " <td>25 431 539</td>" +
                    "<td>6 771 675</td>" +
                    "<td>41 991 316</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>2002</td>" +
                    " <td> 9 803 498</td>" +
                    " <td>25 173 706</td>" +
                    "<td>6 780 094</td>" +
                    "<td>41 757 298</td>"+ 
                    "</tr>"+

                    "<tr>"+
                    " <td>2004</td>" +
                    " <td> 10 069 346</td>" +
                    " <td>25 201 155</td>" +
                    "<td>6 609 937</td>" +
                    "<td>41 880 438</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>2004</td>" +
                    " <td> 10 069 346</td>" +
                    " <td>25 201 155</td>" +
                    "<td>6 609 937</td>" +
                    "<td>41 880 438</td>"+
                    "</tr>",

                    ShortDescription ="Number of livestock",
                    ImageUrl="agriculturel.jpg",
                    
                    CategoryId = 1
                },
                   new Tuik() {
                    Id = 2,
                    Name ="Population of People",
                     TableColumnName ="<th>Census Year</th>" +
                    "<th>Total</th>"+
                    "<th>Number</th>"+
                    "<th>Rate(%)</th>",
                    Description =" <tr>" +
                    "<td>1935</td>" +
                    " <td>16 158 018</td>" +
                    " <td>15 195 859</td>" +
                    "<td>94.05</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>1945</td>" +
                    " <td>18 790 174</td>" +
                    " <td>17 957 558</td>" +
                    "<td>95.57</td>" +

                    "<tr>"+
                    " <td>1950</td>" +
                    " <td>20 947 188</td>" +
                    " <td>20 180 424</td>" +
                    "<td>96.39</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>1955</td>" +
                    " <td>24 064 763</td>" +
                    " <td>23 172 925</td>" +
                    "<td>96.48</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>1960</td>" +
                    " <td>27 754 820</td>" +
                    " <td>26 786 180</td>" +
                    "<td>96.57</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>1965</td>" +
                    " <td>31 391 421</td>" +
                    " <td>30 482 810</td>" +
                    "<td>97.12</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>1970</td>" +
                    " <td>35 605 176</td>" +
                    " <td>34 713 754</td>" +
                    "<td>97.50</td>" +
                    "</tr>",

                    ShortDescription ="Population Census, 1935-2000",
                    ImageUrl="population.png",
                   
                    CategoryId = 2
                },
                     new Tuik() {
                    Id = 2,
                    Name ="Age and Sex",
                     TableColumnName ="<th>Age Group</th>" +
                    "<th>Population of place of residence</th>"+
                    "<th>Migrated population</th>"+
                    "<th>Migration rate(%)</th>",
                    Description =" <tr>" +
                    "<td>1-4</td>" +
                    " <td>4,946</td>" +
                    " <td>206</td>" +
                    "<td>4.2</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>5-9</td>" +
                    " <td>6,096</td>" +
                    " <td>214</td>" +
                    "<td>3.5</td>" +

                    "<tr>"+
                    " <td>10-14</td>" +
                    " <td>6,604</td>" +
                    " <td>193</td>" +
                    "<td>2.9</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>15-19</td>" +
                    " <td>6,314</td>" +
                    " <td>433</td>" +
                    "<td>6.9</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>20-24</td>" +
                    " <td>6,251</td>" +
                    " <td>570</td>" +
                    "<td>9.1</td>" +
                    "</tr>",

                    ShortDescription ="Age and Sex specific migration rate, 2010-2011",
                    ImageUrl="population.png",

                    CategoryId = 2
                },
                    new Tuik() {
                    Id = 3,
                    Name ="Number of Literacy Cource",
                     TableColumnName ="<th>Year</th>" +
                    "<th>Total</th>"+
                    "<th>15-44</th>"+
                    "<th>45+</th>",
                    Description =" <tr>" +
                    "<td>2009-2010</td>" +
                    " <td> 485 747</td>" +
                    " <td> 291 287</td>" +
                    "<td> 194 460</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>2010-2011</td>" +
                    " <td>934 263</td>" +
                    " <td>406 230</td>" +
                    "<td> 528 033</td>" +

                    "<tr>"+
                    " <td>2011-2012</td>" +
                    " <td> 747 117</td>" +
                    " <td> 277 260</td>" +
                    "<td> 469 857</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>2012-2013</td>" +
                    " <td> 210 020</td>" +
                    " <td> 146 299</td>" +
                    "<td> 63 721</td>" +
                    "</tr>"+

                    "<tr>"+
                    " <td>2013-2014</td>" +
                    " <td> 172 242</td>" +
                    " <td> 126 051</td>" +
                    "<td> 46 191</td>" +
                    "</tr>",

                    ShortDescription ="Number of literacy course successful finishers by age group and sex, 2009-2017",
                    ImageUrl="Education.jpg",

                    CategoryId = 3
                },
                    new Tuik() {
                    Id = 4,
                    Name ="Industrial production index, 2005-2019",
                     TableColumnName ="",
                    Description ="",

                    ShortDescription ="",
                    ImageUrl="indust.jpg",

                    CategoryId = 4
                },
                    new Tuik() {
                    Id = 5,
                    Name ="Using Of Internet Technology",
                     TableColumnName ="",
                    Description ="",

                    ShortDescription ="",
                    ImageUrl="it.jpg",

                    CategoryId = 5
                },
             
                /*
                new Tuik() { 
                    Id = 2, 
                    Name = "Mühendislik", 
                    Description = "<p>Mühendislik descrpiton uzunnnnnn</p>",
                    ShortDescription ="Mühendislik hakkında",
                    ImageUrl = "2.jpg" ,
                    CategoryId = 1
                },
                new Tuik() { 
                    Id = 3,
                    Name = "Tıp", 
                    Description = "<p>Tıp Description uzunnnnnn</p>",
                    ShortDescription ="Tıp hakkında",
                    ImageUrl = "3.jpg" ,
                    CategoryId = 3
                },
                new Tuik() {
                    Id = 4, 
                    Name = "Bilişim",
                    Description = "<p>Bilişim Description uzunnnnnn</p>",
                    ShortDescription ="Bilişim hakkında",
                    ImageUrl = "4.jpg" ,
                    CategoryId = 2
                }, 
                */
            };
        } 
       
        public static List<Tuik> Tuiks
        {
            get
            {
                return _tuiks;
            }
        }

        public static void AddTuik(Tuik entity)
        {
            _tuiks.Add(entity);
        }
        public static Tuik GetByID(int id)
        {
            //id ye göre sorgu yapıyoruz listedeki id ile eşleşirse değeri döndürcek.
            return _tuiks.FirstOrDefault(i => i.Id == id);

        }
    }
}
    