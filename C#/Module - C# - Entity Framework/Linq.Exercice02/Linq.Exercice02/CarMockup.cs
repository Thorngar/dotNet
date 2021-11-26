using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Exercice02
{
    using System;
    using System.Collections.Generic;


    public class CarMockup
    {
        public static List<Car> GetAll()
        {
            var listVoiture = new List<Car>();

            listVoiture.Add(new Car() { Id = 1, Color = ColorType.Red, CreationDate = new DateTime(2012, 10, 10), Manufacturer = "Opel", Speed = 180 });
            listVoiture.Add(new Car() { Id = 2, Color = ColorType.Gray, CreationDate = new DateTime(2010, 05, 10), Manufacturer = "Citroen", Speed = 150 });
            listVoiture.Add(new Car() { Id = 3, Color = ColorType.Blue, CreationDate = new DateTime(2007, 01, 30), Manufacturer = "Toyota", Speed = 140 });
            listVoiture.Add(new Car() { Id = 4, Color = ColorType.Yellow, CreationDate = new DateTime(2011, 12, 20), Manufacturer = "Renault", Speed = 185 });
            listVoiture.Add(new Car() { Id = 5, Color = ColorType.Gray, CreationDate = new DateTime(2012, 10, 10), Manufacturer = "Citroen", Speed = 156 });
            listVoiture.Add(new Car() { Id = 6, Color = ColorType.Blue, CreationDate = new DateTime(2008, 10, 10), Manufacturer = "Opel", Speed = 120 });
            listVoiture.Add(new Car() { Id = 7, Color = ColorType.White, CreationDate = new DateTime(2007, 10, 10), Manufacturer = "Toyota", Speed = 205 });
            listVoiture.Add(new Car() { Id = 8, Color = ColorType.Gray, CreationDate = new DateTime(2004, 10, 10), Manufacturer = "Opel", Speed = 252 });
            listVoiture.Add(new Car() { Id = 9, Color = ColorType.Red, CreationDate = new DateTime(2006, 10, 10), Manufacturer = "Citroen", Speed = 120 });
            listVoiture.Add(new Car() { Id = 10, Color = ColorType.Red, CreationDate = new DateTime(2003, 10, 10), Manufacturer = "Toyota", Speed = 40 });
            listVoiture.Add(new Car() { Id = 11, Color = ColorType.Blue, CreationDate = new DateTime(2002, 10, 10), Manufacturer = "Renault", Speed = 80 });
            listVoiture.Add(new Car() { Id = 12, Color = ColorType.Red, CreationDate = new DateTime(2013, 10, 10), Manufacturer = "Citroen", Speed = 78 });
            listVoiture.Add(new Car() { Id = 13, Color = ColorType.Gray, CreationDate = new DateTime(2002, 10, 10), Manufacturer = "Renault", Speed = 120 });
            listVoiture.Add(new Car() { Id = 14, Color = ColorType.Blue, CreationDate = new DateTime(2010, 10, 10), Manufacturer = "Opel", Speed = 98 });
            listVoiture.Add(new Car() { Id = 15, Color = ColorType.Red, CreationDate = new DateTime(2012, 10, 10), Manufacturer = "Citroen", Speed = 120 });
            listVoiture.Add(new Car() { Id = 16, Color = ColorType.Gray, CreationDate = new DateTime(2005, 10, 10), Manufacturer = "Renault", Speed = 150 });
            listVoiture.Add(new Car() { Id = 17, Color = ColorType.Red, CreationDate = new DateTime(2006, 10, 10), Manufacturer = "Citroen", Speed = 154 });
            listVoiture.Add(new Car() { Id = 18, Color = ColorType.Gray, CreationDate = new DateTime(2008, 10, 10), Manufacturer = "Opel", Speed = 120 });
            listVoiture.Add(new Car() { Id = 19, Color = ColorType.Blue, CreationDate = new DateTime(2014, 10, 10), Manufacturer = "Opel", Speed = 188 });
            listVoiture.Add(new Car() { Id = 20, Color = ColorType.Red, CreationDate = new DateTime(2013, 10, 10), Manufacturer = "Toyota", Speed = 196 });

            return listVoiture;
        }
    }
}
