using Microsoft.AspNetCore.Mvc;
using Web_PersonelCars.Models;

namespace Web_PersonelCars.Controllers
{
    public class PersonelController : Controller
    {
        List<Personel> _personels = new List<Personel>()
        {
            new Personel()
            {
                FirstName="Ali",
                LastName = "Sağlam",
                Cars=new List<Car> {
                    new Car() {ModelYear=2015,ModelName="Opel"},
                    new Car() {ModelYear=2003,ModelName="Honda"}
                }
            },
            new Personel()
            {
                FirstName="Ahmet",
                LastName = "Serçe",
                Cars=new List<Car> {
                    new Car() {ModelYear=1998,ModelName="Toyota"},
                    new Car() {ModelYear=2008,ModelName="Peugeot"}
                }
            },
            new Personel()
            {
                FirstName="Mehmet",
                LastName = "Gün",
                Cars=new List<Car> {
                    new Car() {ModelYear=1989,ModelName="BMW"},
                    new Car() {ModelYear=2003,ModelName="Mercedes"}
                }
            },
            new Personel()
            {
                FirstName="Hüseyin",
                LastName = "Tok",
                Cars=new List<Car> {
                    new Car() {ModelYear=2022,ModelName="Chevrelot"},
                    new Car() {ModelYear=2020,ModelName="Citroen"}
                }
            },
            new Personel()
            {
                FirstName="Alp",
                LastName = "Dağ",
                Cars=new List<Car> {
                    new Car() {ModelYear=2013,ModelName="Dacia"},
                    new Car() {ModelYear=2015,ModelName="Renault"}
                }
            },
            new Personel()
            {
                FirstName="Cem",
                LastName = "Yılmaz",
                Cars=new List<Car> {
                    new Car() {ModelYear=2002,ModelName="Fiat"},
                    new Car() {ModelYear=2000,ModelName="Ford"}
                }
            }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OtherPersonels()
        {
            return View(_personels);
        }
        public IActionResult Doga()
        {
            return View();
        }
        public IActionResult ShowCars2(int PersonelId)
        {
            return View(_personels[PersonelId].Cars);
        }

        public IActionResult ShowCars()
        {
            Personel personel = new Personel();
            personel.FirstName = "Doğa";
            personel.LastName = "Yılmaz";
            Car car1 = new()
            {
                ModelName = "Tofaş",
                ModelYear = 2010,
                Personel = personel,
            };
            Car car2 = new()
            {
                ModelName = "Ford",
                ModelYear = 2015,
                Personel = personel,
            };
            Car car3 = new()
            {
                ModelName = "Audi",
                ModelYear = 2013,
                Personel = personel,
            };
            personel.Cars.Add(car1);
            personel.Cars.Add(car2);
            personel.Cars.Add(car3);
            return View(personel.Cars);
        }


    }
}
