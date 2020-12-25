using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsAirplane
{
    class AirportCollection
    {
        //Словарь (хранилище) с парковками
        readonly Dictionary<string, Airport<Plane, BoombsStandart>> airportStages;
        protected readonly char separator = ':';

        //Возвращение списка названий праковок
        public List<string> Keys => airportStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public AirportCollection(int pictureWidth, int pictureHeight)
        {
            airportStages = new Dictionary<string, Airport<Plane, BoombsStandart>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        //Добавление парковки
        public void AddAirport(string name)
        {
            if (airportStages.ContainsKey(name))
            {
                return;
            }
            airportStages.Add(name, new Airport<Plane, BoombsStandart>(pictureWidth, pictureHeight));
        }
        //Удаление парковки
        public void DelAirport(string name)
        {
            if (airportStages.ContainsKey(name))
            {
                airportStages.Remove(name);
            }
        }
        //Доступ к парковке
        public Airport<Plane, BoombsStandart> this[string ind]
        {
            get
            {
                if (airportStages.ContainsKey(ind))
                {
                    return airportStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"AirportCollection");

                    foreach (var level in airportStages)
                    {
                        sw.WriteLine($"Airport{separator}{level.Key}");
                        ITransport plane = null;
                        for (int i = 0; (plane = level.Value[i]) != null; i++)
                        {
                            if (plane != null)
                            {
                                if (plane.GetType().Name == "WarPlane")
                                {
                                    sw.Write($"WarPlane{separator}");

                                }
                                if (plane.GetType().Name == "Bomber")
                                {
                                    sw.Write($"Bomber{separator}");
                                }
                                //Записываемые параметры
                                sw.WriteLine(plane);
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool SaveData(string filename, string dockName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (!airportStages.ContainsKey(dockName))
            {
                return false;
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"OnlyOneAirport");

                    sw.WriteLine($"Airport{separator}{dockName}");
                    ITransport plane = null;
                    var level = airportStages[dockName];


                    for (int i = 0; (plane = level[i]) != null; i++)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "WarPlane")
                            {
                                sw.Write($"WarPlane{separator}");

                            }
                            if (plane.GetType().Name == "Bomber")
                            {
                                sw.Write($"Bomber{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(plane);
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadAirportCollection(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("AirportCollection"))
                {
                    //очищаем записи
                    airportStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                line = sr.ReadLine();
                Plane plane = null;
                string key = string.Empty;
                while (line != null && line.Contains("Airport"))
                {
                    key = line.Split(separator)[1];
                    airportStages.Add(key, new Airport<Plane, BoombsStandart>(pictureWidth, pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("WarPlane") || line.Contains("Bomber")))
                    {
                        if (line.Split(separator)[0] == "WarPlane")
                        {
                            plane = new WarPlane(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Bomber")
                        {
                            plane = new Bomber(line.Split(separator)[1]);
                        }
                        var result = airportStages[key] + plane;
                        if (!result)
                        {
                            return false;
                        }
                        line = sr.ReadLine();
                    }
                }
                return true;
            }
        }
        public bool LoadAirport(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();

                if (line.Contains("OnlyOneAirport")) { }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                line = sr.ReadLine();
                Plane plane = null;
                string key = string.Empty;
                if (line != null && line.Contains("Airport"))
                {
                    key = line.Split(separator)[1];
                    if (airportStages.ContainsKey(key))
                    {
                        airportStages[key].ClearPlaces();
                    }
                    else
                    {
                        airportStages.Add(key, new Airport<Plane, BoombsStandart>(pictureWidth, pictureHeight));
                    }

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("WarPlane") || line.Contains("Bomber")))
                    {
                        if (line.Split(separator)[0] == "WarPlane")
                        {
                            plane = new WarPlane(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Bomber")
                        {
                            plane = new Bomber(line.Split(separator)[1]);
                        }
                        var result = airportStages[key] + plane;
                        if (!result)
                        {
                            return false;
                        }
                        line = sr.ReadLine();
                    }
                }
                else return false;
                return true;
            }
        }
    }
}
