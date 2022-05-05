using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace F1_FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new TeamContext(
                serviceProvider.GetRequiredService<DbContextOptions<TeamContext>>()))
            {
                if (db.Teams.Any())
                {
                    return;
                }

                db.Teams.AddRange(
                    new Team
                    {
                        TeamName = "Ferrari",
                        Base = "Maranello, Italy",
                        Chief = "Mattia Binotto",
                        Chasis = "F1-75",
                        PowerUnit = "Ferrari",
                        FirstEntry = 1950,
                        Championships = 16,
                        PolePositions = 232,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Charles",
                                LastName = "Leclerc",
                                Number = 16,
                                BirthDate = DateTime.Parse("10/16/1997"),
                                Country = "Monaco",
                                Podiums = 16,
                                Points = 646,
                                GPEntered = 85,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {
                                    new Circuit {
                                        GPName = "Azerbaijan Grand Prix",
                                        CircuitName = "Baku City Circuit",
                                        Location = "Baku, Azerbaijan",
                                        FirstGP = 2016,
                                        Length = (6.003),
                                        LapRecord = "1:43.009"
                                    },
                                    new Circuit {
                                        GPName = "Aramco United States Grand Prix",
                                        CircuitName = "Circuit of The Americas",
                                        Location = "Austin, Texas, United States",
                                        FirstGP = 2012,
                                        Length = (5.513),
                                        LapRecord = "1:36.169"
                                    },
                                    new Circuit {
                                        GPName = "Heineken Australian Grand Prix",
                                        CircuitName = "Albert Park Circuit",
                                        Location = "Melbourne, Australia",
                                        FirstGP = 1996,
                                        Length = (5.278),
                                        LapRecord = "1:20.260"
                                    }
                                }
                            },
                            new Driver {
                                FirstName = "Carlos",
                                LastName = "Sainz",
                                Number = 55,
                                BirthDate = DateTime.Parse("01/09/1994"),
                                Country = "Spain",
                                Podiums = 8,
                                Points = 574.5,
                                GPEntered = 145,
                                Championships = 0,
                                Circuits = new List<Circuit>    {
                                    new Circuit {
                                        GPName = "Austrian Grand Prix",
                                        CircuitName = "Red Bull Ring",
                                        Location = "Spielberg, Styria, Austria",
                                        FirstGP = 1970,
                                        Length = (4.318),
                                        LapRecord = "1:05.619"
                                    }
                                }
                            },
                            new Driver {
                                FirstName = "Kimi",
                                LastName = "Raikkonen",
                                Number = 7,
                                BirthDate = DateTime.Parse("10/17/1979"),
                                Country = "Finland",
                                Podiums = 103,
                                Points = 1873,
                                GPEntered = 353,
                                Championships = 1,
                                Circuits = new List<Circuit>    {
                                }
                            },
                            new Driver {
                                FirstName = "Michael",
                                LastName = "Schumacher",
                                Number = 7,
                                BirthDate = DateTime.Parse("03/01/1969"),
                                Country = "Germany",
                                Podiums = 155,
                                Points = 1566,
                                GPEntered = 308,
                                Championships = 7,
                                Circuits = new List<Circuit>    {
                                }
                            },
                            new Driver {
                                FirstName = "Ayrton",
                                LastName = "Senna",
                                Number = 27,
                                BirthDate = DateTime.Parse("03/21/1960"),
                                Country = "Brazil",
                                Podiums = 80,
                                Points = 614,
                                GPEntered = 162,
                                Championships = 3,
                                Circuits = new List<Circuit>    {
                                }
                            }
                        }
                    },
                    new Team
                    {
                        TeamName = "Red Bull Racing",
                        Base = "Milton Keynes, United Kingdom",
                        Chief = "Christian Horner",
                        Chasis = "RB18",
                        PowerUnit = "Red Bull Powertrains",
                        FirstEntry = 1997,
                        Championships = 4,
                        PolePositions = 75,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Max",
                                LastName = "Verstappen",
                                Number = 1,
                                BirthDate = DateTime.Parse("09/30/1997"),
                                Country = "Netherlands",
                                Podiums = 62,
                                Points = 1616.5,
                                GPEntered = 145,
                                Championships = 1, 
                                Circuits = new List<Circuit>    {
                                    new Circuit {
                                        GPName = "Spanish Grand Prix",
                                        CircuitName = "Circuit de Barcelona - Catalunya",
                                        Location = "Barcelona, Spain",
                                        FirstGP = 1991,
                                        Length = (4.678),
                                        LapRecord = "1:18.149"
                                    },
                                    new Circuit {
                                        GPName = "British Grand Prix",
                                        CircuitName = "Silverstone Circuit",
                                        Location = "Silverstone, United Kingdom",
                                        FirstGP = 1950,
                                        Length = (5.891),
                                        LapRecord = "1:27.097"
                                    },
                                    new Circuit {
                                        GPName = "Abu Dhabi Grand Prix",
                                        CircuitName = "Yas Marina Circuit",
                                        Location = "Yas Island, Abu Dhabi, United Arab Emirates",
                                        FirstGP = 2009,
                                        Length = (5.281),
                                        LapRecord = "1:26.103"
                                    }
                                }
                            },
                            new Driver {
                                FirstName = "Sergio",
                                LastName = "Perez",
                                Number = 11,
                                BirthDate = DateTime.Parse("01/26/1990"),
                                Country = "Mexico",
                                Podiums = 17,
                                Points = 950,
                                GPEntered = 218,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {
                                }
                            }
                        }
                    },
                    new Team
                    {
                        TeamName = "Mercedes-AMG",
                        Base = "Brackley, United Kingdom",
                        Chief = "Toto Wolff",
                        Chasis = "W13",
                        PowerUnit = "Mercedes",
                        FirstEntry = 1970,
                        Championships = 8,
                        PolePositions = 127,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Lewis",
                                LastName = "Hamilton",
                                Number = 44,
                                BirthDate = DateTime.Parse("01/07/1984"),
                                Country = "England",
                                Podiums = 183,
                                Points = 4193.5,
                                GPEntered = 292,
                                Championships = 7, 
                                Circuits = new List<Circuit>    {
                                    new Circuit {
                                        GPName = "Saudi Arabian Grand Prix",
                                        CircuitName = "Jeddah Corniche Circuit",
                                        Location = "Jeddah, Saudi Arabia",
                                        FirstGP = 2021,
                                        Length = (6.174),
                                        LapRecord = "1:30.734"
                                    },
                                    new Circuit {
                                        GPName = "Emilia Romagna Grand Prix",
                                        CircuitName = "Autodromo Enzo e Dino Ferrari",
                                        Location = "Imola, Itlay",
                                        FirstGP = 1980,
                                        Length = (4.909),
                                        LapRecord = "1:15.484"
                                    },
                                    new Circuit {
                                        GPName = "Grand Prix de Monaco",
                                        CircuitName = "Circuit de Monaco",
                                        Location = "Monaco, France",
                                        FirstGP = 1950,
                                        Length = (3.337),
                                        LapRecord = "1:12.909"
                                    },
                                    new Circuit {
                                        GPName = "Hungarian Grand Prix",
                                        CircuitName = "Hungaroring",
                                        Location = "Mogyorod, Hungary",
                                        FirstGP = 1986,
                                        Length = (4.381),
                                        LapRecord = "1:16.627"
                                    },
                                    new Circuit {
                                        GPName = "Heineken Dutch Grand Prix",
                                        CircuitName = "Circuit Zandvoort",
                                        Location = "Zandvoort, North Holland, Netherlands",
                                        FirstGP = 1952,
                                        Length = (4.259),
                                        LapRecord = "1:11.097"
                                    },
                                    new Circuit {
                                        GPName = "Japanese Grand Prix",
                                        CircuitName = "Suzuka Circuit",
                                        Location = "Suzuka, Japan",
                                        FirstGP = 1987,
                                        Length = (5.807),
                                        LapRecord = "1:30.983"
                                    }
                                }
                            },
                            new Driver {
                                FirstName = "George",
                                LastName = "Russell",
                                Number = 63,
                                BirthDate = DateTime.Parse("02/15/1998"),
                                Country = "England",
                                Podiums = 2,
                                Points = 68,
                                GPEntered = 64,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {   
                                }
                            },
                            new Driver {
                                FirstName = "Nico",
                                LastName = "Rosberg",
                                Number = 6,
                                BirthDate = DateTime.Parse("06/27/1985"),
                                Country = "Germany",
                                Podiums = 57,
                                Points = 1594.5,
                                GPEntered = 206,
                                Championships = 1, 
                                Circuits = new List<Circuit>    {   
                                }
                            },
                            new Driver {
                                FirstName = "Jenson",
                                LastName = "Button",
                                Number = 22,
                                BirthDate = DateTime.Parse("01/19/1980"),
                                Country = "England",
                                Podiums = 50,
                                Points = 1235,
                                GPEntered = 309,
                                Championships = 1,
                                Circuits = new List<Circuit>    {
                                }
                            }
                        }
                    },
                        new Team
                    {
                        TeamName = "McLaren",
                        Base = "Woking, United Kingdom",
                        Chief = "Andreas Seidl",
                        Chasis = "MCL36",
                        PowerUnit = "Mercedes",
                        FirstEntry = 1966,
                        Championships = 8,
                        PolePositions = 156,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Daniel",
                                LastName = "Ricciardo",
                                Number = 3,
                                BirthDate = DateTime.Parse("07/01/1989"),
                                Country = "Australia",
                                Podiums = 32,
                                Points = 1285,
                                GPEntered = 214,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {   
                                }
                            },
                            new Driver {
                                FirstName = "Lando",
                                LastName = "Norris",
                                Number = 4,
                                BirthDate = DateTime.Parse("11/13/1999"),
                                Country = "England",
                                Podiums = 6,
                                Points = 341,
                                GPEntered = 64,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {   
                                }
                            }

                        }
                    },
                    new Team
                    {
                        TeamName = "Alfa Romeo",
                        Base = "Hinwil, Switzerland",
                        Chief = "Frederic Vasseur",
                        Chasis = "C42",
                        PowerUnit = "Ferrari",
                        FirstEntry = 1993,
                        Championships = 0,
                        PolePositions = 1,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Valtteri",
                                LastName = "Bottas",
                                Number = 77,
                                BirthDate = DateTime.Parse("08/28/1989"),
                                Country = "Finland",
                                Podiums = 67,
                                Points = 1762,
                                GPEntered = 182,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {   
                                    new Circuit {
                                        GPName = "Grand Prix Du Canada",
                                        CircuitName = "Circuit Gilles-Villeneuve",
                                        Location = "Montreal, Quebec, Canada",
                                        FirstGP = 1978,
                                        Length = (4.361),
                                        LapRecord = "1:13.078"
                                    },
                                    new Circuit {
                                        GPName = "Rolex Belgian Grand Prix",
                                        CircuitName = "Circuit de Spa-Francorchamps",
                                        Location = "Stavelot, Belgium",
                                        FirstGP = 1950,
                                        Length = (7.004),
                                        LapRecord = "1:46.286"
                                    },
                                    new Circuit {
                                        GPName = "Mexico Grand Prix",
                                        CircuitName = "Autodromo Hermanos Rodríguez",
                                        Location = "Mexico City, Mexico",
                                        FirstGP = 1963,
                                        Length = (4.304),
                                        LapRecord = "1:17.774"
                                    },
                                    new Circuit {
                                        GPName = "Brazilian Grand Prix",
                                        CircuitName = "Autódromo José Carlos Pace",
                                        Location = "Sao Paulo, Brazil",
                                        FirstGP = 1973,
                                        Length = (4.309),
                                        LapRecord = "1:10.540"
                                    }
                                }
                            },
                            new Driver {
                                FirstName = "Zhou",
                                LastName = "Guanyu",
                                Number = 24,
                                BirthDate = DateTime.Parse("05/30/1999"),
                                Country = "China",
                                Podiums = 0,
                                Points = 1,
                                GPEntered = 4,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {   
                                }
                            }
                        }
                    },
                    new Team
                    {
                        TeamName = "BWT Alpine",
                        Base = "Enstone, United Kingdom",
                        Chief = "Otmar Szafnauer",
                        Chasis = "A522",
                        PowerUnit = "Renault",
                        FirstEntry = 1986,
                        Championships = 2,
                        PolePositions = 20,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Fernando",
                                LastName = "Alonso",
                                Number = 14,
                                BirthDate = DateTime.Parse("07/29/1982"),
                                Country = "Spain",
                                Podiums = 98,
                                Points = 1982,
                                GPEntered = 340,
                                Championships = 2, 
                                Circuits = new List<Circuit>    { 
                                }
                            },
                            new Driver {
                                FirstName = "Esteban",
                                LastName = "Ocon",
                                Number = 31,
                                BirthDate = DateTime.Parse("09/17/1996"),
                                Country = "France",
                                Podiums = 2,
                                Points = 292,
                                GPEntered = 93,
                                Championships = 0, 
                                Circuits = new List<Circuit>    { 
                                }
                            }
                        }
                    },
                    new Team
                    {
                        TeamName = "AlphaTauri",
                        Base = "Faenza, Italy",
                        Chief = "Franz Tost",
                        Chasis = "AT03",
                        PowerUnit = "Red Bull Powertrains",
                        FirstEntry = 1985,
                        Championships = 0,
                        PolePositions = 1,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Pierre",
                                LastName = "Gasly",
                                Number = 10,
                                BirthDate = DateTime.Parse("02/07/1996"),
                                Country = "France",
                                Podiums = 3,
                                Points = 315,
                                GPEntered = 90,
                                Championships = 0, 
                                Circuits = new List<Circuit>    { 
                                }
                            },
                            new Driver {
                                FirstName = "Yuki",
                                LastName = "Tsunoda",
                                Number = 22,
                                BirthDate = DateTime.Parse("05/11/2000"),
                                Country = "Japan",
                                Podiums = 0,
                                Points = 42,
                                GPEntered = 26,
                                Championships = 0, 
                                Circuits = new List<Circuit>    { 
                                }
                            }
                        }
                    },
                    new Team
                    {
                        TeamName = "Haas",
                        Base = "Kannapolis, North Carolina, United States",
                        Chief = "Guenther Steiner",
                        Chasis = "VF-22",
                        PowerUnit = "Ferrari",
                        FirstEntry = 2016,
                        Championships = 0,
                        PolePositions = 0,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Mick",
                                LastName = "Schumacher",
                                Number = 47,
                                BirthDate = DateTime.Parse("03/22/1999"),
                                Country = "Germany",
                                Podiums = 0,
                                Points = 0,
                                GPEntered = 25,
                                Championships = 0, 
                                Circuits = new List<Circuit>    { 
                                }
                            },
                            new Driver {
                                FirstName = "Kevin",
                                LastName = "Magnussen",
                                Number = 20,
                                BirthDate = DateTime.Parse("10/05/1992"),
                                Country = "Denmark",
                                Podiums = 1,
                                Points = 173,
                                GPEntered = 124,
                                Championships = 0, 
                                Circuits = new List<Circuit>    { 
                                    new Circuit {
                                        GPName = "Singapore Grand Prix",
                                        CircuitName = "Marina Bay Street Circuit",
                                        Location = "Marina Bay, Singapore",
                                        FirstGP = 2008,
                                        Length = (5.063),
                                        LapRecord = "1:41.905"
                                    }
                                }
                            }
                        }
                    },
                    new Team
                    {
                        TeamName = "Aston Martin",
                        Base = "Silverstone, United Kingdom",
                        Chief = "Mike Krack",
                        Chasis = "AMR22",
                        PowerUnit = "Mercedes",
                        FirstEntry = 2018,
                        Championships = 0,
                        PolePositions = 1,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Sebastian",
                                LastName = "Vettel",
                                Number = 5,
                                BirthDate = DateTime.Parse("07/03/1987"),
                                Country = "Germany",
                                Podiums = 122,
                                Points = 3065,
                                GPEntered = 282,
                                Championships = 4, 
                                Circuits = new List<Circuit>    { 
                                    new Circuit {
                                        GPName = "Grand Prix de France",
                                        CircuitName = "Circuit Paul Ricard",
                                        Location = "Le Castellet, France",
                                        FirstGP = 1971,
                                        Length = (5.842),
                                        LapRecord = "1:32.740"
                                    }
                                }
                            },
                            new Driver {
                                FirstName = "Lance",
                                LastName = "Stroll",
                                Number = 18,
                                BirthDate = DateTime.Parse("10/29/1998"),
                                Country = "Canada",
                                Podiums = 3,
                                Points = 177,
                                GPEntered = 104,
                                Championships = 0, 
                                Circuits = new List<Circuit>    { 
                                }
                            }
                        }
                    },
                    new Team
                    {
                        TeamName = "Williams Racing",
                        Base = "Grove, United Kingdom",
                        Chief = "Jost Capito",
                        Chasis = "FW44",
                        PowerUnit = "Mercedes",
                        FirstEntry = 1978,
                        Championships = 9,
                        PolePositions = 128,
                        Drivers = new List<Driver>  {
                            new Driver {
                                FirstName = "Nicholas",
                                LastName = "Latifi",
                                Number = 6,
                                BirthDate = DateTime.Parse("06/29/1995"),
                                Country = "Canada",
                                Podiums = 0,
                                Points = 7,
                                GPEntered = 43,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {
                                }
                            },
                            new Driver {
                                FirstName = "Alexander",
                                LastName = "Albon",
                                Number = 23,
                                BirthDate = DateTime.Parse("03/23/1996"),
                                Country = "Thailand",
                                Podiums = 2,
                                Points = 198,
                                GPEntered = 42,
                                Championships = 0, 
                                Circuits = new List<Circuit>    {
                                }
                            }
                        }
                    }
                );
                db.SaveChanges();
            }
        }
    }
}