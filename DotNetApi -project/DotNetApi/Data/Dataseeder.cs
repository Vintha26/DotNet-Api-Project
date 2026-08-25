using DotNetApi.Model;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DotNetApi.Data
{
    public static class DataSeeder
    {
        public static async Task SeedAsync(AppDbContext context)
        {

            if (await context.Customers.AnyAsync())
            {
                return;
            }

            var customers = new List<Customer>
{
    new Customer
    {
        CustomerName = "Alfreds Futterkiste",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Obere Str. 57",
        CustomerCity = "Berlin",
        CustomerPostalCode = "12209",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Ana Trujillo Emparedados y helados",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Avda. de la Constitución 2222",
        CustomerCity = "México D.F.",
        CustomerPostalCode = "05021",
        CustomerCountry = "Mexico"
    },

    new Customer
    {
        CustomerName = "Antonio Moreno Taquería",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Mataderos 2312",
        CustomerCity = "México D.F.",
        CustomerPostalCode = "05023",
        CustomerCountry = "Mexico"
    },

    new Customer
    {
        CustomerName = "Around the Horn",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "120 Hanover Sq.",
        CustomerCity = "London",
        CustomerPostalCode = "WA1 1DP",
        CustomerCountry = "UK"
    },

    new Customer
    {
        CustomerName = "Berglunds snabbköp",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Berguvsvägen 8",
        CustomerCity = "Luleå",
        CustomerPostalCode = "S-958 22",
        CustomerCountry = "Sweden"
    },

    new Customer
    {
        CustomerName = "Blauer See Delikatessen",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Forsterstr. 57",
        CustomerCity = "Mannheim",
        CustomerPostalCode = "68306",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Blondel père et fils",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "24, place Kléber",
        CustomerCity = "Strasbourg",
        CustomerPostalCode = "67000",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Bólido Comidas preparadas",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "C/ Araquil, 67",
        CustomerCity = "Madrid",
        CustomerPostalCode = "28023",
        CustomerCountry = "Spain"
    },

    new Customer
    {
        CustomerName = "Bon app'",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "12, rue des Bouchers",
        CustomerCity = "Marseille",
        CustomerPostalCode = "13008",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Bottom-Dollar Marketse",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "23 Tsawassen Blvd.",
        CustomerCity = "Tsawassen",
        CustomerPostalCode = "T2F 8M4",
        CustomerCountry = "Canada"
    },

    new Customer
    {
        CustomerName = "B's Beverages",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Fauntleroy Circus",
        CustomerCity = "London",
        CustomerPostalCode = "EC2 5NT",
        CustomerCountry = "UK"
    },

    new Customer
    {
        CustomerName = "Cactus Comidas para llevar",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Cerrito 333",
        CustomerCity = "Buenos Aires",
        CustomerPostalCode = "1010",
        CustomerCountry = "Argentina"
    },

    new Customer
    {
        CustomerName = "Centro comercial Moctezuma",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Sierras de Granada 9993",
        CustomerCity = "México D.F.",
        CustomerPostalCode = "05022",
        CustomerCountry = "Mexico"
    },

    new Customer
    {
        CustomerName = "Chop-suey Chinese",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Hauptstr. 29",
        CustomerCity = "Bern",
        CustomerPostalCode = "3012",
        CustomerCountry = "Switzerland"
    },

    new Customer
    {
        CustomerName = "Comércio Mineiro",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Av. dos Lusíadas, 23",
        CustomerCity = "São Paulo",
        CustomerPostalCode = "05432-043",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "Consolidated Holdings",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Berkeley Gardens 12 Brewery",
        CustomerCity = "London",
        CustomerPostalCode = "WX1 6LT",
        CustomerCountry = "UK"
    },

    new Customer
    {
        CustomerName = "Drachenblut Delikatessend",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Walserweg 21",
        CustomerCity = "Aachen",
        CustomerPostalCode = "52066",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Du monde entier",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "67, rue des Cinquante Otages",
        CustomerCity = "Nantes",
        CustomerPostalCode = "44000",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Eastern Connection",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "35 King George",
        CustomerCity = "London",
        CustomerPostalCode = "WX3 6FW",
        CustomerCountry = "UK"
    },

    new Customer
    {
        CustomerName = "Ernst Handel",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Kirchgasse 6",
        CustomerCity = "Graz",
        CustomerPostalCode = "8010",
        CustomerCountry = "Austria"
    },

    new Customer
    {
        CustomerName = "Familia Arquibaldo",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Rua Orós, 92",
        CustomerCity = "São Paulo",
        CustomerPostalCode = "05442-030",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "FISSA Fabrica Inter. Salchichas S.A.",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "C Moralzarzal, 86",
        CustomerCity = "Madrid",
        CustomerPostalCode = "28034",
        CustomerCountry = "Spain"
    },

    new Customer
    {
        CustomerName = "Folies gourmandes",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "184, chaussée de Tournai",
        CustomerCity = "Lille",
        CustomerPostalCode = "59000",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Folk och fä HB",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Åkergatan 24",
        CustomerCity = "Bräcke",
        CustomerPostalCode = "S-844 67",
        CustomerCountry = "Sweden"
    },

    new Customer
    {
        CustomerName = "Frankenversand",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Berliner Platz 43",
        CustomerCity = "München",
        CustomerPostalCode = "80805",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "France restauration",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "54, rue Royale",
        CustomerCity = "Nantes",
        CustomerPostalCode = "44000",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Franchi S.p.A.",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Via Monte Bianco 34",
        CustomerCity = "Torino",
        CustomerPostalCode = "10100",
        CustomerCountry = "Italy"
    },

    new Customer
    {
        CustomerName = "Furia Bacalhau e Frutos do Mar",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Jardim das rosas n. 32",
        CustomerCity = "Lisboa",
        CustomerPostalCode = "1675",
        CustomerCountry = "Portugal"
    },

    new Customer
    {
        CustomerName = "Galería del gastrónomo",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Rambla de Cataluña, 23",
        CustomerCity = "Barcelona",
        CustomerPostalCode = "08022",
        CustomerCountry = "Spain"
    },

    new Customer
    {
        CustomerName = "Godos Cocina Típica",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "C Romero, 33",
        CustomerCity = "Sevilla",
        CustomerPostalCode = "41101",
        CustomerCountry = "Spain"
    },

    new Customer
    {
        CustomerName = "Gourmet Lanchonetes",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Av. Brasil, 442",
        CustomerCity = "Campinas",
        CustomerPostalCode = "04876-786",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "Great Lakes Food Market",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "2732 Baker Blvd.",
        CustomerCity = "Eugene",
        CustomerPostalCode = "97403",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "GROSELLA-Restaurante",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "5ª Ave. Los Palos Grandes",
        CustomerCity = "Caracas",
        CustomerPostalCode = "1081",
        CustomerCountry = "Venezuela"
    },

    new Customer
    {
        CustomerName = "Hanari Carnes",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Rua do Paço, 67",
        CustomerCity = "Rio de Janeiro",
        CustomerPostalCode = "05454-876",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "HILARIÓN-Abastos",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Carrera 22 con Ave. Carlos Soublette #8-35",
        CustomerCity = "San Cristóbal",
        CustomerPostalCode = "5022",
        CustomerCountry = "Venezuela"
    },

    new Customer
    {
        CustomerName = "Hungry Coyote Import Store",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "City Center Plaza 516 Main St.",
        CustomerCity = "Elgin",
        CustomerPostalCode = "97827",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Hungry Owl All-Night Grocers",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "8 Johnstown Road",
        CustomerCity = "Cork",
        CustomerPostalCode = "",
        CustomerCountry = "Ireland"
    },

    new Customer
    {
        CustomerName = "Island Trading",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Garden House Crowther Way",
        CustomerCity = "Cowes",
        CustomerPostalCode = "PO31 7PJ",
        CustomerCountry = "UK"
    },

    new Customer
    {
        CustomerName = "Königlich Essen",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Maubelstr. 90",
        CustomerCity = "Brandenburg",
        CustomerPostalCode = "14776",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "La corne d'abondance",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "67, avenue de l'Europe",
        CustomerCity = "Versailles",
        CustomerPostalCode = "78000",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "La maison d'Asie",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "1 rue Alsace-Lorraine",
        CustomerCity = "Toulouse",
        CustomerPostalCode = "31000",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Laughing Bacchus Wine Cellars",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "1900 Oak St.",
        CustomerCity = "Vancouver",
        CustomerPostalCode = "V3F 2K1",
        CustomerCountry = "Canada"
    },

    new Customer
    {
        CustomerName = "Lazy K Kountry Store",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "12 Orchestra Terrace",
        CustomerCity = "Walla Walla",
        CustomerPostalCode = "99362",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Lehmanns Marktstand",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Magazinweg 7",
        CustomerCity = "Frankfurt a.M.",
        CustomerPostalCode = "60528",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Let's Stop N Shop",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "87 Polk St. Suite 5",
        CustomerCity = "San Francisco",
        CustomerPostalCode = "94117",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "LILA-Supermercado",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Carrera 52 con Ave. Bolívar #65-98 Llano Largo",
        CustomerCity = "Barquisimeto",
        CustomerPostalCode = "3508",
        CustomerCountry = "Venezuela"
    },

    new Customer
    {
        CustomerName = "LINO-Delicateses",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Ave. 5 de Mayo Porlamar",
        CustomerCity = "I. de Margarita",
        CustomerPostalCode = "4980",
        CustomerCountry = "Venezuela"
    },

    new Customer
    {
        CustomerName = "Lonesome Pine Restaurant",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "89 Chiaroscuro Rd.",
        CustomerCity = "Portland",
        CustomerPostalCode = "97219",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Magazzini Alimentari Riuniti",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Via Ludovico il Moro 22",
        CustomerCity = "Bergamo",
        CustomerPostalCode = "24100",
        CustomerCountry = "Italy"
    },

    new Customer
    {
        CustomerName = "Maison Dewey",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Rue Joseph-Bens 532",
        CustomerCity = "Bruxelles",
        CustomerPostalCode = "B-1180",
        CustomerCountry = "Belgium"
    },

    new Customer
    {
        CustomerName = "Mère Paillarde",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "43 rue St. Laurent",
        CustomerCity = "Montréal",
        CustomerPostalCode = "H1J 1C3",
        CustomerCountry = "Canada"
    },

    new Customer
    {
        CustomerName = "Morgenstern Gesundkost",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Heerstr. 22",
        CustomerCity = "Leipzig",
        CustomerPostalCode = "04179",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "North/South",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "South House 300 Queensbridge",
        CustomerCity = "London",
        CustomerPostalCode = "SW7 1RZ",
        CustomerCountry = "UK"
    },

    new Customer
    {
        CustomerName = "Océano Atlántico Ltda.",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Ing. Gustavo Moncada 8585 Piso 20-A",
        CustomerCity = "Buenos Aires",
        CustomerPostalCode = "1010",
        CustomerCountry = "Argentina"
    },

    new Customer
    {
        CustomerName = "Old World Delicatessen",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "2743 Bering St.",
        CustomerCity = "Anchorage",
        CustomerPostalCode = "99508",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Ottilies Käseladen",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Mehrheimerstr. 369",
        CustomerCity = "Köln",
        CustomerPostalCode = "50739",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Paris spécialités",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "265, boulevard Charonne",
        CustomerCity = "Paris",
        CustomerPostalCode = "75012",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Pericles Comidas clásicas",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Calle Dr. Jorge Cash 321",
        CustomerCity = "México D.F.",
        CustomerPostalCode = "05033",
        CustomerCountry = "Mexico"
    },

    new Customer
    {
        CustomerName = "Piccolo und mehr",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Geislweg 14",
        CustomerCity = "Salzburg",
        CustomerPostalCode = "5020",
        CustomerCountry = "Austria"
    },

    new Customer
    {
        CustomerName = "Princesa Isabel Vinhoss",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Estrada da saúde n. 58",
        CustomerCity = "Lisboa",
        CustomerPostalCode = "1756",
        CustomerCountry = "Portugal"
    },

    new Customer
    {
        CustomerName = "Que Delícia",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Rua da Panificadora, 12",
        CustomerCity = "Rio de Janeiro",
        CustomerPostalCode = "02389-673",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "Queen Cozinha",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Alameda dos Canàrios, 891",
        CustomerCity = "São Paulo",
        CustomerPostalCode = "05487-020",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "QUICK-Stop",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Taucherstraße 10",
        CustomerCity = "Cunewalde",
        CustomerPostalCode = "01307",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Rancho grande",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Av. del Libertador 900",
        CustomerCity = "Buenos Aires",
        CustomerPostalCode = "1010",
        CustomerCountry = "Argentina"
    },

    new Customer
    {
        CustomerName = "Rattlesnake Canyon Grocery",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "2817 Milton Dr.",
        CustomerCity = "Albuquerque",
        CustomerPostalCode = "87110",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Reggiani Caseifici",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Strada Provinciale 124",
        CustomerCity = "Reggio Emilia",
        CustomerPostalCode = "42100",
        CustomerCountry = "Italy"
    },

    new Customer
    {
        CustomerName = "Ricardo Adocicados",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Av. Copacabana, 267",
        CustomerCity = "Rio de Janeiro",
        CustomerPostalCode = "02389-890",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "Richter Supermarkt",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Grenzacherweg 237",
        CustomerCity = "Genève",
        CustomerPostalCode = "1203",
        CustomerCountry = "Switzerland"
    },

    new Customer
    {
        CustomerName = "Romero y tomillo",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Gran Vía, 1",
        CustomerCity = "Madrid",
        CustomerPostalCode = "28001",
        CustomerCountry = "Spain"
    },

    new Customer
    {
        CustomerName = "Santé Gourmet",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Erling Skakkes gate 78",
        CustomerCity = "Stavern",
        CustomerPostalCode = "4110",
        CustomerCountry = "Norway"
    },

    new Customer
    {
        CustomerName = "Save-a-lot Markets",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "187 Suffolk Ln.",
        CustomerCity = "Boise",
        CustomerPostalCode = "83720",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Seven Seas Imports",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "90 Wadhurst Rd.",
        CustomerCity = "London",
        CustomerPostalCode = "OX15 4NB",
        CustomerCountry = "UK"
    },

    new Customer
    {
        CustomerName = "Simons bistro",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Vinbæltet 34",
        CustomerCity = "København",
        CustomerPostalCode = "1734",
        CustomerCountry = "Denmark"
    },

    new Customer
    {
        CustomerName = "Spécialités du monde",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "25, rue Lauriston",
        CustomerCity = "Paris",
        CustomerPostalCode = "75016",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Split Rail Beer & Ale",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "P.O. Box 555",
        CustomerCity = "Lander",
        CustomerPostalCode = "82520",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Suprêmes délices",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Boulevard Tirou, 255",
        CustomerCity = "Charleroi",
        CustomerPostalCode = "B-6000",
        CustomerCountry = "Belgium"
    },

    new Customer
    {
        CustomerName = "The Big Cheese",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "89 Jefferson Way Suite 2",
        CustomerCity = "Portland",
        CustomerPostalCode = "97201",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "The Cracker Box",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "55 Grizzly Peak Rd.",
        CustomerCity = "Butte",
        CustomerPostalCode = "59801",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Toms Spezialitäten",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Luisenstr. 48",
        CustomerCity = "Münster",
        CustomerPostalCode = "44087",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Tortuga Restaurante",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Avda. Azteca 123",
        CustomerCity = "México D.F.",
        CustomerPostalCode = "05033",
        CustomerCountry = "Mexico"
    },

    new Customer
    {
        CustomerName = "Tradição Hipermercados",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Av. Inês de Castro, 414",
        CustomerCity = "São Paulo",
        CustomerPostalCode = "05634-030",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "Trail's Head Gourmet Provisioners",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "722 DaVinci Blvd.",
        CustomerCity = "Kirkland",
        CustomerPostalCode = "98034",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Vaffeljernet",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Smagsløget 45",
        CustomerCity = "Århus",
        CustomerPostalCode = "8200",
        CustomerCountry = "Denmark"
    },

    new Customer
    {
        CustomerName = "Victuailles en stock",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "2, rue du Commerce",
        CustomerCity = "Lyon",
        CustomerPostalCode = "69004",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Vins et alcools Chevalier",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "59 rue de l'Abbaye",
        CustomerCity = "Reims",
        CustomerPostalCode = "51100",
        CustomerCountry = "France"
    },

    new Customer
    {
        CustomerName = "Die Wandernde Kuh",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Adenauerallee 900",
        CustomerCity = "Stuttgart",
        CustomerPostalCode = "70563",
        CustomerCountry = "Germany"
    },

    new Customer
    {
        CustomerName = "Wartian Herkku",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Torikatu 38",
        CustomerCity = "Oulu",
        CustomerPostalCode = "90110",
        CustomerCountry = "Finland"
    },

    new Customer
    {
        CustomerName = "Wellington Importadora",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Rua do Mercado, 12",
        CustomerCity = "Resende",
        CustomerPostalCode = "08737-363",
        CustomerCountry = "Brazil"
    },

    new Customer
    {
        CustomerName = "White Clover Markets",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "305 - 14th Ave. S. Suite 3B",
        CustomerCity = "Seattle",
        CustomerPostalCode = "98128",
        CustomerCountry = "USA"
    },

    new Customer
    {
        CustomerName = "Wilman Kala",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "Keskuskatu 45",
        CustomerCity = "Helsinki",
        CustomerPostalCode = "21240",
        CustomerCountry = "Finland"
    },

    new Customer
    {
        CustomerName = "Wolski",
        CustomerEmail = string.Empty,
        CustomerPhone = string.Empty,
        CustomerAddress = "ul. Filtrowa 68",
        CustomerCity = "Walla",
        CustomerPostalCode = "01-012",
        CustomerCountry = "Poland"
    }
};

            context.Customers.AddRange(customers);
            await context.SaveChangesAsync();

            // Employee
            var employees = new List<Employee>
{
    new Employee
    {
        EmployeeFirstName = "Nancy",
        EmployeeLastName = "Davolio",
        Birthday = new DateTime(1968, 12, 8),
        Notes = "Education includes a BA in psychology from Colorado State University. She also completed (The Art of the Cold Call). Nancy is a member of 'Toastmasters International'."
    },

    new Employee
    {
        EmployeeFirstName = "Andrew",
        EmployeeLastName = "Fuller",
        Birthday = new DateTime(1952, 2, 19),
        Notes = "Andrew received his BTS commercial and a Ph.D. in international marketing from the University of Dallas. He is fluent in French and Italian and reads German. He joined the company as a sales representative, was promoted to sales manager and was then named vice president of sales. Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association."
    },

    new Employee
    {
        EmployeeFirstName = "Janet",
        EmployeeLastName = "Leverling",
        Birthday = new DateTime(1963, 8, 30),
        Notes = "Janet has a BS degree in chemistry from Boston College). She has also completed a certificate program in food retailing management. Janet was hired as a sales associate and was promoted to sales representative."
    },

    new Employee
    {
        EmployeeFirstName = "Margaret",
        EmployeeLastName = "Peacock",
        Birthday = new DateTime(1958, 9, 19),
        Notes = "Margaret holds a BA in English literature from Concordia College and an MA from the American Institute of Culinary Arts. She was temporarily assigned to the London office before returning to her permanent post in Seattle."
    },

    new Employee
    {
        EmployeeFirstName = "Steven",
        EmployeeLastName = "Buchanan",
        Birthday = new DateTime(1955, 3, 4),
        Notes = "Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree. Upon joining the company as a sales representative, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London, where he was promoted to sales manager. Mr. Buchanan has completed the courses 'Successful Telemarketing' and 'International Sales Management'. He is fluent in French."
    },

    new Employee
    {
        EmployeeFirstName = "Michael",
        EmployeeLastName = "Suyama",
        Birthday = new DateTime(1963, 7, 2),
        Notes = "Michael is a graduate of Sussex University (MA, economics) and the University of California at Los Angeles (MBA, marketing). He has also taken the courses 'Multi-Cultural Selling' and 'Time Management for the Sales Professional'. He is fluent in Japanese and can read and write French, Portuguese, and Spanish."
    },

    new Employee
    {
        EmployeeFirstName = "Robert",
        EmployeeLastName = "King",
        Birthday = new DateTime(1960, 5, 29),
        Notes = "Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan and then joining the company. After completing a course entitled 'Selling in Europe', he was transferred to the London office."
    },

    new Employee
    {
        EmployeeFirstName = "Laura",
        EmployeeLastName = "Callahan",
        Birthday = new DateTime(1958, 1, 9),
        Notes = "Laura received a BA in psychology from the University of Washington. She has also completed a course in business French. She reads and writes French."
    },

    new Employee
    {
        EmployeeFirstName = "Anne",
        EmployeeLastName = "Dodsworth",
        Birthday = new DateTime(1969, 7, 2),
        Notes = "Anne has a BA degree in English from St. Lawrence College. She is fluent in French and German."
    },

    new Employee
    {
        EmployeeFirstName = "Adam",
        EmployeeLastName = "West",
        Birthday = new DateTime(1928, 9, 19),
        Notes = "An old chum."
    }
};

            context.Employees.AddRange(employees);

            await context.SaveChangesAsync();

            // Shipper
            var shippers = new List<Shipper>
{
    new Shipper
    {
        ShipperName = "Speedy Express",
        phone = "(503) 555-9831"
    },

    new Shipper
    {
        ShipperName = "United Package",
        phone = "(503) 555-3199"
    },

    new Shipper
    {
        ShipperName = "Federal Shipping",
        phone = "(503) 555-9931"
    }
};

            context.Shippers.AddRange(shippers);

            await context.SaveChangesAsync();

            // Category
            var categories = new List<Category>
{
    new Category
    {
        CategoryName = "Beverages",
        CategoryDescription = "Soft drinks, coffees, teas, beers, and ales"
    },

    new Category
    {
        CategoryName = "Condiments",
        CategoryDescription = "Sweet and savory sauces, relishes, spreads, and seasonings"
    },

    new Category
    {
        CategoryName = "Confections",
        CategoryDescription = "Desserts, candies, and sweet breads"
    },

    new Category
    {
        CategoryName = "Dairy Products",
        CategoryDescription = "Cheeses"
    },

    new Category
    {
        CategoryName = "Grains/Cereals",
        CategoryDescription = "Breads, crackers, pasta, and cereal"
    },

    new Category
    {
        CategoryName = "Meat/Poultry",
        CategoryDescription = "Prepared meats"
    },

    new Category
    {
        CategoryName = "Produce",
        CategoryDescription = "Dried fruit and bean curd"
    },

    new Category
    {
        CategoryName = "Seafood",
        CategoryDescription = "Seaweed and fish"
    }
};

            context.Categories.AddRange(categories);

            await context.SaveChangesAsync();

            // Supplier
            var suppliers = new List<Supplier>
{
    new Supplier
    {
        SupplierName = "Exotic Liquid",
        SupplierEmail = string.Empty,
        SupplierPhone = "(171) 555-2222",
        SupplierCity = "Londona",
        SupplierCountry = "UK"
    },

    new Supplier
    {
        SupplierName = "New Orleans Cajun Delights",
        SupplierEmail = string.Empty,
        SupplierPhone = "(100) 555-4822",
        SupplierCity = "New Orleans",
        SupplierCountry = "USA"
    },

    new Supplier
    {
        SupplierName = "Grandma Kelly's Homestead",
        SupplierEmail = string.Empty,
        SupplierPhone = "(313) 555-5735",
        SupplierCity = "Ann Arbor",
        SupplierCountry = "USA"
    },

    new Supplier
    {
        SupplierName = "Tokyo Traders",
        SupplierEmail = string.Empty,
        SupplierPhone = "(03) 3555-5011",
        SupplierCity = "Tokyo",
        SupplierCountry = "Japan"
    },

    new Supplier
    {
        SupplierName = "Cooperativa de Quesos 'Las Cabras'",
        SupplierEmail = string.Empty,
        SupplierPhone = "(98) 598 76 54",
        SupplierCity = "Oviedo",
        SupplierCountry = "Spain"
    },

    new Supplier
    {
        SupplierName = "Mayumi's",
        SupplierEmail = string.Empty,
        SupplierPhone = "(06) 431-7877",
        SupplierCity = "Osaka",
        SupplierCountry = "Japan"
    },

    new Supplier
    {
        SupplierName = "Pavlova, Ltd.",
        SupplierEmail = string.Empty,
        SupplierPhone = "(03) 444-2343",
        SupplierCity = "Melbourne",
        SupplierCountry = "Australia"
    },

    new Supplier
    {
        SupplierName = "Specialty Biscuits, Ltd.",
        SupplierEmail = string.Empty,
        SupplierPhone = "(161) 555-4448",
        SupplierCity = "Manchester",
        SupplierCountry = "UK"
    },

    new Supplier
    {
        SupplierName = "PB Knäckebröd AB",
        SupplierEmail = string.Empty,
        SupplierPhone = "031-987 65 43",
        SupplierCity = "Göteborg",
        SupplierCountry = "Sweden"
    },

    new Supplier
    {
        SupplierName = "Refrescos Americanas LTDA",
        SupplierEmail = string.Empty,
        SupplierPhone = "(11) 555 4640",
        SupplierCity = "São Paulo",
        SupplierCountry = "Brazil"
    },

    new Supplier
    {
        SupplierName = "Heli Süßwaren GmbH & Co. KG",
        SupplierEmail = string.Empty,
        SupplierPhone = "(010) 9984510",
        SupplierCity = "Berlin",
        SupplierCountry = "Germany"
    },

    new Supplier
    {
        SupplierName = "Plutzer Lebensmittelgroßmärkte AG",
        SupplierEmail = string.Empty,
        SupplierPhone = "(069) 992755",
        SupplierCity = "Frankfurt",
        SupplierCountry = "Germany"
    },

    new Supplier
    {
        SupplierName = "Nord-Ost-Fisch Handelsgesellschaft mbH",
        SupplierEmail = string.Empty,
        SupplierPhone = "(04721) 8713",
        SupplierCity = "Cuxhaven",
        SupplierCountry = "Germany"
    },

    new Supplier
    {
        SupplierName = "Formaggi Fortini s.r.l.",
        SupplierEmail = string.Empty,
        SupplierPhone = "(0544) 60323",
        SupplierCity = "Ravenna",
        SupplierCountry = "Italy"
    },

    new Supplier
    {
        SupplierName = "Norske Meierier",
        SupplierEmail = string.Empty,
        SupplierPhone = "(0)2-953010",
        SupplierCity = "Sandvika",
        SupplierCountry = "Norway"
    },

    new Supplier
    {
        SupplierName = "Bigfoot Breweries",
        SupplierEmail = string.Empty,
        SupplierPhone = "(503) 555-9931",
        SupplierCity = "Bend",
        SupplierCountry = "USA"
    },

    new Supplier
    {
        SupplierName = "Svensk Sjöföda AB",
        SupplierEmail = string.Empty,
        SupplierPhone = "08-123 45 67",
        SupplierCity = "Stockholm",
        SupplierCountry = "Sweden"
    },

    new Supplier
    {
        SupplierName = "Aux joyeux ecclésiastiques",
        SupplierEmail = string.Empty,
        SupplierPhone = "(1) 03.83.00.68",
        SupplierCity = "Paris",
        SupplierCountry = "France"
    },

    new Supplier
    {
        SupplierName = "New England Seafood Cannery",
        SupplierEmail = string.Empty,
        SupplierPhone = "(617) 555-3267",
        SupplierCity = "Boston",
        SupplierCountry = "USA"
    },

    new Supplier
    {
        SupplierName = "Leka Trading",
        SupplierEmail = string.Empty,
        SupplierPhone = "555-8787",
        SupplierCity = "Singapore",
        SupplierCountry = "Singapore"
    },

    new Supplier
    {
        SupplierName = "Lyngbysild",
        SupplierEmail = string.Empty,
        SupplierPhone = "43844108",
        SupplierCity = "Lyngby",
        SupplierCountry = "Denmark"
    },

    new Supplier
    {
        SupplierName = "Zaanse Snoepfabriek",
        SupplierEmail = string.Empty,
        SupplierPhone = "(12345) 1212",
        SupplierCity = "Zaandam",
        SupplierCountry = "Netherlands"
    },

    new Supplier
    {
        SupplierName = "Karkki Oy",
        SupplierEmail = string.Empty,
        SupplierPhone = "(953) 10956",
        SupplierCity = "Lappeenranta",
        SupplierCountry = "Finland"
    },

    new Supplier
    {
        SupplierName = "G'day, Mate",
        SupplierEmail = string.Empty,
        SupplierPhone = "(02) 555-5914",
        SupplierCity = "Sydney",
        SupplierCountry = "Australia"
    },

    new Supplier
    {
        SupplierName = "Ma Maison",
        SupplierEmail = string.Empty,
        SupplierPhone = "(514) 555-9022",
        SupplierCity = "Montréal",
        SupplierCountry = "Canada"
    },

    new Supplier
    {
        SupplierName = "Pasta Buttini s.r.l.",
        SupplierEmail = string.Empty,
        SupplierPhone = "(089) 6547665",
        SupplierCity = "Salerno",
        SupplierCountry = "Italy"
    },

    new Supplier
    {
        SupplierName = "Escargots Nouveaux",
        SupplierEmail = string.Empty,
        SupplierPhone = "85.57.00.07",
        SupplierCity = "Montceau",
        SupplierCountry = "France"
    },

    new Supplier
    {
        SupplierName = "Gai pâturage",
        SupplierEmail = string.Empty,
        SupplierPhone = "38.76.98.06",
        SupplierCity = "Annecy",
        SupplierCountry = "France"
    },

    new Supplier
    {
        SupplierName = "Forêts d'érables",
        SupplierEmail = string.Empty,
        SupplierPhone = "(514) 555-2955",
        SupplierCity = "Ste-Hyacinthe",
        SupplierCountry = "Canada"
    }
};

            context.Suppliers.AddRange(suppliers);

            await context.SaveChangesAsync();



            // Product
            var products = new List<Product>
{
    new Product { ProductName = "Chais", SupplierId = suppliers[0].SupplierId, CategoryId = categories[0].CategoryId, Unit = "10 boxes x 20 bags", Price = 18m },
    new Product { ProductName = "Chang", SupplierId = suppliers[0].SupplierId, CategoryId = categories[0].CategoryId, Unit = "24 - 12 oz bottles", Price = 19m },
    new Product { ProductName = "Aniseed Syrup", SupplierId = suppliers[0].SupplierId, CategoryId = categories[1].CategoryId, Unit = "12 - 550 ml bottles", Price = 10m },
    new Product { ProductName = "Chef Anton's Cajun Seasoning", SupplierId = suppliers[1].SupplierId, CategoryId = categories[1].CategoryId, Unit = "48 - 6 oz jars", Price = 22m },
    new Product { ProductName = "Chef Anton's Gumbo Mix", SupplierId = suppliers[1].SupplierId, CategoryId = categories[1].CategoryId, Unit = "36 boxes", Price = 21.35m },
    new Product { ProductName = "Grandma's Boysenberry Spread", SupplierId = suppliers[2].SupplierId, CategoryId = categories[1].CategoryId, Unit = "12 - 8 oz jars", Price = 25m },
    new Product { ProductName = "Uncle Bob's Organic Dried Pears", SupplierId = suppliers[2].SupplierId, CategoryId = categories[6].CategoryId, Unit = "12 - 1 lb pkgs.", Price = 30m },
    new Product { ProductName = "Northwoods Cranberry Sauce", SupplierId = suppliers[2].SupplierId, CategoryId = categories[1].CategoryId, Unit = "12 - 12 oz jars", Price = 40m },
    new Product { ProductName = "Mishi Kobe Niku", SupplierId = suppliers[3].SupplierId, CategoryId = categories[5].CategoryId, Unit = "18 - 500 g pkgs.", Price = 97m },
    new Product { ProductName = "Ikura", SupplierId = suppliers[3].SupplierId, CategoryId = categories[7].CategoryId, Unit = "12 - 200 ml jars", Price = 31m },

    new Product { ProductName = "Queso Cabrales", SupplierId = suppliers[4].SupplierId, CategoryId = categories[3].CategoryId, Unit = "1 kg pkg.", Price = 21m },
    new Product { ProductName = "Queso Manchego La Pastora", SupplierId = suppliers[4].SupplierId, CategoryId = categories[3].CategoryId, Unit = "10 - 500 g pkgs.", Price = 38m },
    new Product { ProductName = "Konbu", SupplierId = suppliers[5].SupplierId, CategoryId = categories[7].CategoryId, Unit = "2 kg box", Price = 6m },
    new Product { ProductName = "Tofu", SupplierId = suppliers[5].SupplierId, CategoryId = categories[6].CategoryId, Unit = "40 - 100 g pkgs.", Price = 23.25m },
    new Product { ProductName = "Genen Shouyu", SupplierId = suppliers[5].SupplierId, CategoryId = categories[1].CategoryId, Unit = "24 - 250 ml bottles", Price = 15.5m },
    new Product { ProductName = "Pavlova", SupplierId = suppliers[6].SupplierId, CategoryId = categories[2].CategoryId, Unit = "32 - 500 g boxes", Price = 17.45m },
    new Product { ProductName = "Alice Mutton", SupplierId = suppliers[6].SupplierId, CategoryId = categories[5].CategoryId, Unit = "20 - 1 kg tins", Price = 39m },
    new Product { ProductName = "Carnarvon Tigers", SupplierId = suppliers[6].SupplierId, CategoryId = categories[7].CategoryId, Unit = "16 kg pkg.", Price = 62.5m },
    new Product { ProductName = "Teatime Chocolate Biscuits", SupplierId = suppliers[7].SupplierId, CategoryId = categories[2].CategoryId, Unit = "10 boxes x 12 pieces", Price = 9.2m },
    new Product { ProductName = "Sir Rodney's Marmalade", SupplierId = suppliers[7].SupplierId, CategoryId = categories[2].CategoryId, Unit = "30 gift boxes", Price = 81m },

    new Product { ProductName = "Sir Rodney's Scones", SupplierId = suppliers[7].SupplierId, CategoryId = categories[2].CategoryId, Unit = "24 pkgs. x 4 pieces", Price = 10m },
    new Product { ProductName = "Gustaf's Knäckebröd", SupplierId = suppliers[8].SupplierId, CategoryId = categories[4].CategoryId, Unit = "24 - 500 g pkgs.", Price = 21m },
    new Product { ProductName = "Tunnbröd", SupplierId = suppliers[8].SupplierId, CategoryId = categories[4].CategoryId, Unit = "12 - 250 g pkgs.", Price = 9m },
    new Product { ProductName = "Guaraná Fantástica", SupplierId = suppliers[9].SupplierId, CategoryId = categories[0].CategoryId, Unit = "12 - 355 ml cans", Price = 4.5m },
    new Product { ProductName = "NuNuCa Nuß-Nougat-Creme", SupplierId = suppliers[10].SupplierId, CategoryId = categories[2].CategoryId, Unit = "20 - 450 g glasses", Price = 14m },
    new Product { ProductName = "Gumbär Gummibärchen", SupplierId = suppliers[10].SupplierId, CategoryId = categories[2].CategoryId, Unit = "100 - 250 g bags", Price = 31.23m },
    new Product { ProductName = "Schoggi Schokolade", SupplierId = suppliers[10].SupplierId, CategoryId = categories[2].CategoryId, Unit = "100 - 100 g pieces", Price = 43.9m },
    new Product { ProductName = "Rössle Sauerkraut", SupplierId = suppliers[11].SupplierId, CategoryId = categories[6].CategoryId, Unit = "25 - 825 g cans", Price = 45.6m },
    new Product { ProductName = "Thüringer Rostbratwurst", SupplierId = suppliers[11].SupplierId, CategoryId = categories[5].CategoryId, Unit = "50 bags x 30 sausgs.", Price = 123.79m },
    new Product { ProductName = "Nord-Ost Matjeshering", SupplierId = suppliers[12].SupplierId, CategoryId = categories[7].CategoryId, Unit = "10 - 200 g glasses", Price = 25.89m },

    new Product { ProductName = "Gorgonzola Telino", SupplierId = suppliers[13].SupplierId, CategoryId = categories[3].CategoryId, Unit = "12 - 100 g pkgs", Price = 12.5m },
    new Product { ProductName = "Mascarpone Fabioli", SupplierId = suppliers[13].SupplierId, CategoryId = categories[3].CategoryId, Unit = "24 - 200 g pkgs.", Price = 32m },
    new Product { ProductName = "Geitost", SupplierId = suppliers[14].SupplierId, CategoryId = categories[3].CategoryId, Unit = "500 g", Price = 2.5m },
    new Product { ProductName = "Sasquatch Ale", SupplierId = suppliers[15].SupplierId, CategoryId = categories[0].CategoryId, Unit = "24 - 12 oz bottles", Price = 14m },
    new Product { ProductName = "Steeleye Stout", SupplierId = suppliers[15].SupplierId, CategoryId = categories[0].CategoryId, Unit = "24 - 12 oz bottles", Price = 18m },
    new Product { ProductName = "Inlagd Sill", SupplierId = suppliers[16].SupplierId, CategoryId = categories[7].CategoryId, Unit = "24 - 250 g jars", Price = 19m },
    new Product { ProductName = "Gravad lax", SupplierId = suppliers[16].SupplierId, CategoryId = categories[7].CategoryId, Unit = "12 - 500 g pkgs.", Price = 26m },
    new Product { ProductName = "Côte de Blaye", SupplierId = suppliers[17].SupplierId, CategoryId = categories[0].CategoryId, Unit = "12 - 75 cl bottles", Price = 263.5m },
    new Product { ProductName = "Chartreuse verte", SupplierId = suppliers[17].SupplierId, CategoryId = categories[0].CategoryId, Unit = "750 cc per bottle", Price = 18m },
    new Product { ProductName = "Boston Crab Meat", SupplierId = suppliers[18].SupplierId, CategoryId = categories[7].CategoryId, Unit = "24 - 4 oz tins", Price = 18.4m },

    new Product { ProductName = "Jack's New England Clam Chowder", SupplierId = suppliers[18].SupplierId, CategoryId = categories[7].CategoryId, Unit = "12 - 12 oz cans", Price = 9.65m },
    new Product { ProductName = "Singaporean Hokkien Fried Mee", SupplierId = suppliers[19].SupplierId, CategoryId = categories[4].CategoryId, Unit = "32 - 1 kg pkgs.", Price = 14m },
    new Product { ProductName = "Ipoh Coffee", SupplierId = suppliers[19].SupplierId, CategoryId = categories[0].CategoryId, Unit = "16 - 500 g tins", Price = 46m },
    new Product { ProductName = "Gula Malacca", SupplierId = suppliers[19].SupplierId, CategoryId = categories[1].CategoryId, Unit = "20 - 2 kg bags", Price = 19.45m },
    new Product { ProductName = "Røgede sild", SupplierId = suppliers[20].SupplierId, CategoryId = categories[7].CategoryId, Unit = "1k pkg.", Price = 9.5m },
    new Product { ProductName = "Spegesild", SupplierId = suppliers[20].SupplierId, CategoryId = categories[7].CategoryId, Unit = "4 - 450 g glasses", Price = 12m },
    new Product { ProductName = "Zaanse koeken", SupplierId = suppliers[21].SupplierId, CategoryId = categories[2].CategoryId, Unit = "10 - 4 oz boxes", Price = 9.5m },
    new Product { ProductName = "Chocolade", SupplierId = suppliers[21].SupplierId, CategoryId = categories[2].CategoryId, Unit = "10 pkgs.", Price = 12.75m },
    new Product { ProductName = "Maxilaku", SupplierId = suppliers[22].SupplierId, CategoryId = categories[2].CategoryId, Unit = "24 - 50 g pkgs.", Price = 20m },
    new Product { ProductName = "Valkoinen suklaa", SupplierId = suppliers[22].SupplierId, CategoryId = categories[2].CategoryId, Unit = "12 - 100 g bars", Price = 16.25m },

    new Product { ProductName = "Manjimup Dried Apples", SupplierId = suppliers[23].SupplierId, CategoryId = categories[6].CategoryId, Unit = "50 - 300 g pkgs.", Price = 53m },
    new Product { ProductName = "Filo Mix", SupplierId = suppliers[23].SupplierId, CategoryId = categories[4].CategoryId, Unit = "16 - 2 kg boxes", Price = 7m },
    new Product { ProductName = "Perth Pasties", SupplierId = suppliers[23].SupplierId, CategoryId = categories[5].CategoryId, Unit = "48 pieces", Price = 32.8m },
    new Product { ProductName = "Tourtière", SupplierId = suppliers[24].SupplierId, CategoryId = categories[5].CategoryId, Unit = "16 pies", Price = 7.45m },
    new Product { ProductName = "Pâté chinois", SupplierId = suppliers[24].SupplierId, CategoryId = categories[5].CategoryId, Unit = "24 boxes x 2 pies", Price = 24m },
    new Product { ProductName = "Gnocchi di nonna Alice", SupplierId = suppliers[25].SupplierId, CategoryId = categories[4].CategoryId, Unit = "24 - 250 g pkgs.", Price = 38m },
    new Product { ProductName = "Ravioli Angelo", SupplierId = suppliers[25].SupplierId, CategoryId = categories[4].CategoryId, Unit = "24 - 250 g pkgs.", Price = 19.5m },
    new Product { ProductName = "Escargots de Bourgogne", SupplierId = suppliers[26].SupplierId, CategoryId = categories[7].CategoryId, Unit = "24 pieces", Price = 13.25m },
    new Product { ProductName = "Raclette Courdavault", SupplierId = suppliers[27].SupplierId, CategoryId = categories[3].CategoryId, Unit = "5 kg pkg.", Price = 55m },
    new Product { ProductName = "Camembert Pierrot", SupplierId = suppliers[27].SupplierId, CategoryId = categories[3].CategoryId, Unit = "15 - 300 g rounds", Price = 34m },

    new Product { ProductName = "Sirop d'érable", SupplierId = suppliers[28].SupplierId, CategoryId = categories[1].CategoryId, Unit = "24 - 500 ml bottles", Price = 28.5m },
    new Product { ProductName = "Tarte au sucre", SupplierId = suppliers[28].SupplierId, CategoryId = categories[2].CategoryId, Unit = "48 pies", Price = 49.3m },
    new Product { ProductName = "Vegie-spread", SupplierId = suppliers[6].SupplierId, CategoryId = categories[1].CategoryId, Unit = "15 - 625 g jars", Price = 43.9m },
    new Product { ProductName = "Wimmers gute Semmelknödel", SupplierId = suppliers[11].SupplierId, CategoryId = categories[4].CategoryId, Unit = "20 bags x 4 pieces", Price = 33.25m },
    new Product { ProductName = "Louisiana Fiery Hot Pepper Sauce", SupplierId = suppliers[1].SupplierId, CategoryId = categories[1].CategoryId, Unit = "32 - 8 oz bottles", Price = 21.05m },
    new Product { ProductName = "Louisiana Hot Spiced Okra", SupplierId = suppliers[1].SupplierId, CategoryId = categories[1].CategoryId, Unit = "24 - 8 oz jars", Price = 17m },
    new Product { ProductName = "Laughing Lumberjack Lager", SupplierId = suppliers[15].SupplierId, CategoryId = categories[0].CategoryId, Unit = "24 - 12 oz bottles", Price = 14m },
    new Product { ProductName = "Scottish Longbreads", SupplierId = suppliers[7].SupplierId, CategoryId = categories[2].CategoryId, Unit = "10 boxes x 8 pieces", Price = 12.5m },
    new Product { ProductName = "Gudbrandsdalsost", SupplierId = suppliers[14].SupplierId, CategoryId = categories[3].CategoryId, Unit = "10 kg pkg.", Price = 36m },
    new Product { ProductName = "Outback Lager", SupplierId = suppliers[6].SupplierId, CategoryId = categories[0].CategoryId, Unit = "24 - 355 ml bottles", Price = 15m },

    new Product { ProductName = "Fløtemysost", SupplierId = suppliers[14].SupplierId, CategoryId = categories[3].CategoryId, Unit = "10 - 500 g pkgs.", Price = 21.5m },
    new Product { ProductName = "Mozzarella di Giovanni", SupplierId = suppliers[13].SupplierId, CategoryId = categories[3].CategoryId, Unit = "24 - 200 g pkgs.", Price = 34.8m },
    new Product { ProductName = "Röd Kaviar", SupplierId = suppliers[16].SupplierId, CategoryId = categories[7].CategoryId, Unit = "24 - 150 g jars", Price = 15m },
    new Product { ProductName = "Longlife Tofu", SupplierId = suppliers[3].SupplierId, CategoryId = categories[6].CategoryId, Unit = "5 kg pkg.", Price = 10m },
    new Product { ProductName = "Rhönbräu Klosterbier", SupplierId = suppliers[11].SupplierId, CategoryId = categories[0].CategoryId, Unit = "24 - 0.5 l bottles", Price = 7.75m },
    new Product { ProductName = "Lakkalikööri", SupplierId = suppliers[22].SupplierId, CategoryId = categories[0].CategoryId, Unit = "500 ml", Price = 18m },
    new Product { ProductName = "Original Frankfurter grüne Soße", SupplierId = suppliers[11].SupplierId, CategoryId = categories[1].CategoryId, Unit = "12 boxes", Price = 13m }
};

            context.Products.AddRange(products);

            await context.SaveChangesAsync();

            // Order
            var orderData = new[]
 {
    (10248, 90, 5, new DateTime(1996, 7, 4), 3),
    (10249, 81, 6, new DateTime(1996, 7, 5), 1),
    (10250, 34, 4, new DateTime(1996, 7, 8), 2),
    (10251, 84, 3, new DateTime(1996, 7, 8), 1),
    (10252, 76, 4, new DateTime(1996, 7, 9), 2),
    (10253, 34, 3, new DateTime(1996, 7, 10), 2),
    (10254, 14, 5, new DateTime(1996, 7, 11), 2),
    (10255, 68, 9, new DateTime(1996, 7, 12), 3),
    (10256, 88, 3, new DateTime(1996, 7, 15), 2),
    (10257, 35, 4, new DateTime(1996, 7, 16), 3),
    (10258, 20, 1, new DateTime(1996, 7, 17), 1),
    (10259, 13, 4, new DateTime(1996, 7, 18), 3),
    (10260, 55, 4, new DateTime(1996, 7, 19), 1),
    (10261, 61, 4, new DateTime(1996, 7, 19), 2),
    (10262, 65, 8, new DateTime(1996, 7, 22), 3),
    (10263, 20, 9, new DateTime(1996, 7, 23), 3),
    (10264, 24, 6, new DateTime(1996, 7, 24), 3),
    (10265, 7, 2, new DateTime(1996, 7, 25), 1),
    (10266, 87, 3, new DateTime(1996, 7, 26), 3),
    (10267, 25, 4, new DateTime(1996, 7, 29), 1),
    (10268, 33, 8, new DateTime(1996, 7, 30), 3),
    (10269, 89, 5, new DateTime(1996, 7, 31), 1),
    (10270, 87, 1, new DateTime(1996, 8, 1), 1),
    (10271, 75, 6, new DateTime(1996, 8, 1), 2),
    (10272, 65, 6, new DateTime(1996, 8, 2), 2),
    (10273, 63, 3, new DateTime(1996, 8, 5), 3),
    (10274, 85, 6, new DateTime(1996, 8, 6), 1),
    (10275, 49, 1, new DateTime(1996, 8, 7), 1),
    (10276, 80, 8, new DateTime(1996, 8, 8), 3),
    (10277, 52, 2, new DateTime(1996, 8, 9), 3),
    (10278, 5, 8, new DateTime(1996, 8, 12), 2),
    (10279, 44, 8, new DateTime(1996, 8, 13), 2),
    (10280, 5, 2, new DateTime(1996, 8, 14), 1),
    (10281, 69, 4, new DateTime(1996, 8, 14), 1),
    (10282, 69, 4, new DateTime(1996, 8, 15), 1),
    (10283, 46, 3, new DateTime(1996, 8, 16), 3),
    (10284, 44, 4, new DateTime(1996, 8, 19), 1),
    (10285, 63, 1, new DateTime(1996, 8, 20), 2),
    (10286, 63, 8, new DateTime(1996, 8, 21), 3),
    (10287, 67, 8, new DateTime(1996, 8, 22), 3),
    (10288, 66, 4, new DateTime(1996, 8, 23), 1),
    (10289, 11, 7, new DateTime(1996, 8, 26), 3),
    (10290, 15, 8, new DateTime(1996, 8, 27), 1),
    (10291, 61, 6, new DateTime(1996, 8, 27), 2),
    (10292, 81, 1, new DateTime(1996, 8, 28), 2),
    (10293, 80, 1, new DateTime(1996, 8, 29), 3),
    (10294, 65, 4, new DateTime(1996, 8, 30), 2),
    (10295, 85, 2, new DateTime(1996, 9, 2), 2),
    (10296, 46, 6, new DateTime(1996, 9, 3), 1),
    (10297, 7, 5, new DateTime(1996, 9, 4), 2),
    (10298, 37, 6, new DateTime(1996, 9, 5), 2),
    (10299, 67, 4, new DateTime(1996, 9, 6), 2),
    (10300, 49, 2, new DateTime(1996, 9, 9), 2),
    (10301, 86, 8, new DateTime(1996, 9, 9), 2),
    (10302, 76, 4, new DateTime(1996, 9, 10), 2),
    (10303, 30, 7, new DateTime(1996, 9, 11), 2),
    (10304, 80, 1, new DateTime(1996, 9, 12), 2),
    (10305, 55, 8, new DateTime(1996, 9, 13), 3),
    (10306, 69, 1, new DateTime(1996, 9, 16), 3),
    (10307, 48, 2, new DateTime(1996, 9, 17), 2),
    (10308, 2, 7, new DateTime(1996, 9, 18), 3),
    (10309, 37, 3, new DateTime(1996, 9, 19), 1),
    (10310, 77, 8, new DateTime(1996, 9, 20), 2),
    (10311, 18, 1, new DateTime(1996, 9, 20), 3),
    (10312, 86, 2, new DateTime(1996, 9, 23), 2),
    (10313, 63, 2, new DateTime(1996, 9, 24), 2),
    (10314, 65, 1, new DateTime(1996, 9, 25), 2),
    (10315, 38, 4, new DateTime(1996, 9, 26), 2),
    (10316, 65, 1, new DateTime(1996, 9, 27), 3),
    (10317, 48, 6, new DateTime(1996, 9, 30), 1),
    (10318, 38, 8, new DateTime(1996, 10, 1), 2),
    (10319, 80, 7, new DateTime(1996, 10, 2), 3),
    (10320, 87, 5, new DateTime(1996, 10, 3), 3),
    (10321, 38, 3, new DateTime(1996, 10, 3), 2),
    (10322, 58, 7, new DateTime(1996, 10, 4), 3),
    (10323, 39, 4, new DateTime(1996, 10, 7), 1),
    (10324, 71, 9, new DateTime(1996, 10, 8), 1),
    (10325, 39, 1, new DateTime(1996, 10, 9), 3),
    (10326, 8, 4, new DateTime(1996, 10, 10), 2),
    (10327, 24, 2, new DateTime(1996, 10, 11), 1),
    (10328, 28, 4, new DateTime(1996, 10, 14), 3),
    (10329, 75, 4, new DateTime(1996, 10, 15), 2),
    (10330, 46, 3, new DateTime(1996, 10, 16), 1),
    (10331, 9, 9, new DateTime(1996, 10, 16), 1),
    (10332, 51, 3, new DateTime(1996, 10, 17), 2),
    (10333, 87, 5, new DateTime(1996, 10, 18), 3),
    (10334, 84, 8, new DateTime(1996, 10, 21), 2),
    (10335, 37, 7, new DateTime(1996, 10, 22), 2),
    (10336, 60, 7, new DateTime(1996, 10, 23), 2),
    (10337, 25, 4, new DateTime(1996, 10, 24), 3),
    (10338, 55, 4, new DateTime(1996, 10, 25), 3),
    (10339, 51, 2, new DateTime(1996, 10, 28), 2),
    (10340, 9, 1, new DateTime(1996, 10, 29), 3),
    (10341, 73, 7, new DateTime(1996, 10, 29), 3),
    (10342, 25, 4, new DateTime(1996, 10, 30), 2),
    (10343, 44, 4, new DateTime(1996, 10, 31), 1),
    (10344, 89, 4, new DateTime(1996, 11, 1), 2),
    (10345, 63, 2, new DateTime(1996, 11, 4), 2),
    (10346, 65, 3, new DateTime(1996, 11, 5), 3),
    (10347, 21, 4, new DateTime(1996, 11, 6), 3),
    (10348, 86, 4, new DateTime(1996, 11, 7), 2),
    (10349, 75, 7, new DateTime(1996, 11, 8), 1),
    (10350, 41, 6, new DateTime(1996, 11, 11), 2),
    (10351, 20, 1, new DateTime(1996, 11, 11), 1),
    (10352, 28, 3, new DateTime(1996, 11, 12), 3),
    (10353, 59, 7, new DateTime(1996, 11, 13), 3),
    (10354, 58, 8, new DateTime(1996, 11, 14), 3),
    (10355, 4, 6, new DateTime(1996, 11, 15), 1),
    (10356, 86, 6, new DateTime(1996, 11, 18), 2),
    (10357, 46, 1, new DateTime(1996, 11, 19), 3),
    (10358, 41, 5, new DateTime(1996, 11, 20), 1),
    (10359, 72, 5, new DateTime(1996, 11, 21), 3),
    (10360, 7, 4, new DateTime(1996, 11, 22), 3),
    (10361, 63, 1, new DateTime(1996, 11, 22), 2),
    (10362, 9, 3, new DateTime(1996, 11, 25), 1),
    (10363, 17, 4, new DateTime(1996, 11, 26), 3),
    (10364, 19, 1, new DateTime(1996, 11, 26), 1),
    (10365, 3, 3, new DateTime(1996, 11, 27), 2),
    (10366, 29, 8, new DateTime(1996, 11, 28), 2),
    (10367, 83, 7, new DateTime(1996, 11, 28), 3),
    (10368, 20, 2, new DateTime(1996, 11, 29), 2),
    (10369, 75, 8, new DateTime(1996, 12, 2), 2),
    (10370, 14, 6, new DateTime(1996, 12, 3), 2),
    (10371, 41, 1, new DateTime(1996, 12, 3), 1),
    (10372, 62, 5, new DateTime(1996, 12, 4), 2),
    (10373, 37, 4, new DateTime(1996, 12, 5), 3),
    (10374, 91, 1, new DateTime(1996, 12, 5), 3),
    (10375, 36, 3, new DateTime(1996, 12, 6), 2),
    (10376, 51, 1, new DateTime(1996, 12, 9), 2),
    (10377, 72, 1, new DateTime(1996, 12, 9), 3),
    (10378, 24, 5, new DateTime(1996, 12, 10), 3),
    (10379, 61, 2, new DateTime(1996, 12, 11), 1),
    (10380, 37, 8, new DateTime(1996, 12, 12), 3),
    (10381, 46, 3, new DateTime(1996, 12, 12), 3),
    (10382, 20, 4, new DateTime(1996, 12, 13), 1),
    (10383, 4, 8, new DateTime(1996, 12, 16), 3),
    (10384, 5, 3, new DateTime(1996, 12, 16), 3),
    (10385, 75, 1, new DateTime(1996, 12, 17), 2),
    (10386, 21, 9, new DateTime(1996, 12, 18), 3),
    (10387, 70, 1, new DateTime(1996, 12, 18), 2),
    (10388, 72, 2, new DateTime(1996, 12, 19), 1),
    (10389, 10, 4, new DateTime(1996, 12, 20), 2),
    (10390, 20, 6, new DateTime(1996, 12, 23), 1),
    (10391, 17, 3, new DateTime(1996, 12, 23), 3),
    (10392, 59, 2, new DateTime(1996, 12, 24), 3),
    (10393, 71, 1, new DateTime(1996, 12, 25), 3),
    (10394, 36, 1, new DateTime(1996, 12, 25), 3),
    (10395, 35, 6, new DateTime(1996, 12, 26), 1),
    (10396, 25, 1, new DateTime(1996, 12, 27), 3),
    (10397, 60, 5, new DateTime(1996, 12, 27), 1),
    (10398, 71, 2, new DateTime(1996, 12, 30), 3),
    (10399, 83, 8, new DateTime(1996, 12, 31), 3),
    (10400, 19, 1, new DateTime(1997, 1, 1), 3),
    (10401, 65, 1, new DateTime(1997, 1, 1), 1),
    (10402, 20, 8, new DateTime(1997, 1, 2), 2),
    (10403, 20, 4, new DateTime(1997, 1, 3), 3),
    (10404, 49, 2, new DateTime(1997, 1, 3), 1),
    (10405, 47, 1, new DateTime(1997, 1, 6), 1),
    (10406, 62, 7, new DateTime(1997, 1, 7), 1),
    (10407, 56, 2, new DateTime(1997, 1, 7), 2),
    (10408, 23, 8, new DateTime(1997, 1, 8), 1),
    (10409, 54, 3, new DateTime(1997, 1, 9), 1),
    (10410, 10, 3, new DateTime(1997, 1, 10), 3),
    (10411, 10, 9, new DateTime(1997, 1, 10), 3),
    (10412, 87, 8, new DateTime(1997, 1, 13), 2),
    (10413, 41, 3, new DateTime(1997, 1, 14), 2),
    (10414, 21, 2, new DateTime(1997, 1, 14), 3),
    (10415, 36, 3, new DateTime(1997, 1, 15), 1),
    (10416, 87, 8, new DateTime(1997, 1, 16), 3),
    (10417, 73, 4, new DateTime(1997, 1, 16), 3),
    (10418, 63, 4, new DateTime(1997, 1, 17), 1),
    (10419, 68, 4, new DateTime(1997, 1, 20), 2),
    (10420, 88, 3, new DateTime(1997, 1, 21), 1),
    (10421, 61, 8, new DateTime(1997, 1, 21), 1),
    (10422, 27, 2, new DateTime(1997, 1, 22), 1),
    (10423, 31, 6, new DateTime(1997, 1, 23), 3),
    (10424, 51, 7, new DateTime(1997, 1, 23), 2),
    (10425, 41, 6, new DateTime(1997, 1, 24), 2),
    (10426, 29, 4, new DateTime(1997, 1, 27), 1),
    (10427, 59, 4, new DateTime(1997, 1, 27), 2),
    (10428, 66, 7, new DateTime(1997, 1, 28), 1),
    (10429, 37, 3, new DateTime(1997, 1, 29), 2),
    (10430, 20, 4, new DateTime(1997, 1, 30), 1),
    (10431, 10, 4, new DateTime(1997, 1, 30), 2),
    (10432, 75, 3, new DateTime(1997, 1, 31), 2),
    (10433, 60, 3, new DateTime(1997, 2, 3), 3),
    (10434, 24, 3, new DateTime(1997, 2, 3), 2),
    (10435, 16, 8, new DateTime(1997, 2, 4), 2),
    (10436, 7, 3, new DateTime(1997, 2, 5), 2),
    (10437, 87, 8, new DateTime(1997, 2, 5), 1),
    (10438, 79, 3, new DateTime(1997, 2, 6), 2),
    (10439, 51, 6, new DateTime(1997, 2, 7), 3),
    (10440, 71, 4, new DateTime(1997, 2, 10), 2),
    (10441, 55, 3, new DateTime(1997, 2, 10), 2),
    (10442, 20, 3, new DateTime(1997, 2, 11), 2),
    (10443, 66, 8, new DateTime(1997, 2, 12), 1)
};

            var orderMap = new Dictionary<int, Order>();

            foreach (var data in orderData)
            {
                var order = new Order
                {
                    CustomerId = customers[data.Item2 - 1].CustomerId,
                    EmployeeId = employees[data.Item3 - 1].EmployeeId,
                    OrderDate = data.Item4,
                    ShipperId = shippers[data.Item5 - 1].ShipperId
                };

                context.Orders.Add(order);

                // Keep original OrderID mapped to the new GUID Order.
                // We need this for OrderDetails.
                orderMap[data.Item1] = order;
            }

            await context.SaveChangesAsync();

            // Order Detail
            var orderDetailData = new[]
 {
               (1, 10248, 11, 12),
(2, 10248, 42, 10),
(3, 10248, 72, 5),
(4, 10249, 14, 9),
(5, 10249, 51, 40),
(6, 10250, 41, 10),
(7, 10250, 51, 35),
(8, 10250, 65, 15),
(9, 10251, 22, 6),
(10, 10251, 57, 15),
(11, 10251, 65, 20),
(12, 10252, 20, 40),
(13, 10252, 33, 25),
(14, 10252, 60, 40),
(15, 10253, 31, 20),
(16, 10253, 39, 42),
(17, 10253, 49, 40),
(18, 10254, 24, 15),
(19, 10254, 55, 21),
(20, 10254, 74, 21),
(21, 10255, 2, 20),
(22, 10255, 16, 35),
(23, 10255, 36, 25),
(24, 10255, 59, 30),
(25, 10256, 53, 15),
(26, 10256, 77, 12),
(27, 10257, 27, 25),
(28, 10257, 39, 6),
(29, 10257, 77, 15),
(30, 10258, 2, 50),
(31, 10258, 5, 65),
(32, 10258, 32, 6),
(33, 10259, 21, 10),
(34, 10259, 37, 1),
(35, 10260, 41, 16),
(36, 10260, 57, 50),
(37, 10260, 62, 15),
(38, 10260, 70, 21),
(39, 10261, 21, 20),
(40, 10261, 35, 20),
(41, 10262, 5, 12),
(42, 10262, 7, 15),
(43, 10262, 56, 2),
(44, 10263, 16, 60),
(45, 10263, 24, 28),
(46, 10263, 30, 60),
(47, 10263, 74, 36),
(48, 10264, 2, 35),
(49, 10264, 41, 25),
(50, 10265, 17, 30),
(51, 10265, 70, 20),
(52, 10266, 12, 12),
(53, 10267, 40, 50),
(54, 10267, 59, 70),
(55, 10267, 76, 15),
(56, 10268, 29, 10),
(57, 10268, 72, 4),
(58, 10269, 33, 60),
(59, 10269, 72, 20),
(60, 10270, 36, 30),
(61, 10270, 43, 25),
(62, 10271, 33, 24),
(63, 10272, 20, 6),
(64, 10272, 31, 40),
(65, 10272, 72, 24),
(66, 10273, 10, 24),
(67, 10273, 31, 15),
(68, 10273, 33, 20),
(69, 10273, 40, 60),
(70, 10273, 76, 33),
(71, 10274, 71, 20),
(72, 10274, 72, 7),
(73, 10275, 24, 12),
(74, 10275, 59, 6),
(75, 10276, 10, 15),
(76, 10276, 13, 10),
(77, 10277, 28, 20),
(78, 10277, 62, 12),
(79, 10278, 44, 16),
(80, 10278, 59, 15),
(81, 10278, 63, 8),
(82, 10278, 73, 25),
(83, 10279, 17, 15),
(84, 10280, 24, 12),
(85, 10280, 55, 20),
(86, 10280, 75, 30),
(87, 10281, 19, 1),
(88, 10281, 24, 6),
(89, 10281, 35, 4),
(90, 10282, 30, 6),
(91, 10282, 57, 2),
(92, 10283, 15, 20),
(93, 10283, 19, 18),
(94, 10283, 60, 35),
(95, 10283, 72, 3),
(96, 10284, 27, 15),
(97, 10284, 44, 21),
(98, 10284, 60, 20),
(99, 10284, 67, 5),
(100, 10285, 1, 45),
(101, 10285, 40, 40),
(102, 10285, 53, 36),
(103, 10286, 35, 100),
(104, 10286, 62, 40),
(105, 10287, 16, 40),
(106, 10287, 34, 20),
(107, 10287, 46, 15),
(108, 10288, 54, 10),
(109, 10288, 68, 3),
(110, 10289, 3, 30),
(111, 10289, 64, 9),
(112, 10290, 5, 20),
(113, 10290, 29, 15),
(114, 10290, 49, 15),
(115, 10290, 77, 10),
(116, 10291, 13, 20),
(117, 10291, 44, 24),
(118, 10291, 51, 2),
(119, 10292, 20, 20),
(120, 10293, 18, 12),
(121, 10293, 24, 10),
(122, 10293, 63, 5),
(123, 10293, 75, 6),
(124, 10294, 1, 18),
(125, 10294, 17, 15),
(126, 10294, 43, 15),
(127, 10294, 60, 21),
(128, 10294, 75, 6),
(129, 10295, 56, 4),
(130, 10296, 11, 12),
(131, 10296, 16, 30),
(132, 10296, 69, 15),
(133, 10297, 39, 60),
(134, 10297, 72, 20),
(135, 10298, 2, 40),
(136, 10298, 36, 40),
(137, 10298, 59, 30),
(138, 10298, 62, 15),
(139, 10299, 19, 15),
(140, 10299, 70, 20),
(141, 10300, 66, 30),
(142, 10300, 68, 20),
(143, 10301, 40, 10),
(144, 10301, 56, 20),
(145, 10302, 17, 40),
(146, 10302, 28, 28),
(147, 10302, 43, 12),
(148, 10303, 40, 40),
(149, 10303, 65, 30),
(150, 10303, 68, 15),
(151, 10304, 49, 30),
(152, 10304, 59, 10),
(153, 10304, 71, 2),
(154, 10305, 18, 25),
(155, 10305, 29, 25),
(156, 10305, 39, 30),
(157, 10306, 30, 10),
(158, 10306, 53, 10),
(159, 10306, 54, 5),
(160, 10307, 62, 10),
(161, 10307, 68, 3),
(162, 10308, 69, 1),
(163, 10308, 70, 5),
(164, 10309, 4, 20),
(165, 10309, 6, 30),
(166, 10309, 42, 2),
(167, 10309, 43, 20),
(168, 10309, 71, 3),
(169, 10310, 16, 10),
(170, 10310, 62, 5),
(171, 10311, 42, 6),
(172, 10311, 69, 7),
(173, 10312, 28, 4),
(174, 10312, 43, 24),
(175, 10312, 53, 20),
(176, 10312, 75, 10),
(177, 10313, 36, 12),
(178, 10314, 32, 40),
(179, 10314, 58, 30),
(180, 10314, 62, 25),
(181, 10315, 34, 14),
(182, 10315, 70, 30),
(183, 10316, 41, 10),
(184, 10316, 62, 70),
(185, 10317, 1, 20),
(186, 10318, 41, 20),
(187, 10318, 76, 6),
(188, 10319, 17, 8),
(189, 10319, 28, 14),
(190, 10319, 76, 30),
(191, 10320, 71, 30),
(192, 10321, 35, 10),
(193, 10322, 52, 20),
(194, 10323, 15, 5),
(195, 10323, 25, 4),
(196, 10323, 39, 4),
(197, 10324, 16, 21),
(198, 10324, 35, 70),
(199, 10324, 46, 30),
(200, 10324, 59, 40),
(201, 10324, 63, 80),
(202, 10325, 6, 6),
(203, 10325, 13, 12),
(204, 10325, 14, 9),
(205, 10325, 31, 4),
(206, 10325, 72, 40),
(207, 10326, 4, 24),
(208, 10326, 57, 16),
(209, 10326, 75, 50),
(210, 10327, 2, 25),
(211, 10327, 11, 50),
(212, 10327, 30, 35),
(213, 10327, 58, 30),
(214, 10328, 59, 9),
(215, 10328, 65, 40),
(216, 10328, 68, 10),
(217, 10329, 19, 10),
(218, 10329, 30, 8),
(219, 10329, 38, 20),
(220, 10329, 56, 12),
(221, 10330, 26, 50),
(222, 10330, 72, 25),
(223, 10331, 54, 15),
(224, 10332, 18, 40),
(225, 10332, 42, 10),
(226, 10332, 47, 16),
(227, 10333, 14, 10),
(228, 10333, 21, 10),
(229, 10333, 71, 40),
(230, 10334, 52, 8),
(231, 10334, 68, 10),
(232, 10335, 2, 7),
(233, 10335, 31, 25),
(234, 10335, 32, 6),
(235, 10335, 51, 48),
(236, 10336, 4, 18),
(237, 10337, 23, 40),
(238, 10337, 26, 24),
(239, 10337, 36, 20),
(240, 10337, 37, 28),
(241, 10337, 72, 25),
(242, 10338, 17, 20),
(243, 10338, 30, 15),
(244, 10339, 4, 10),
(245, 10339, 17, 70),
(246, 10339, 62, 28),
(247, 10340, 18, 20),
(248, 10340, 41, 12),
(249, 10340, 43, 40),
(250, 10341, 33, 8),
(251, 10341, 59, 9),
(252, 10342, 2, 24),
(253, 10342, 31, 56),
(254, 10342, 36, 40),
(255, 10342, 55, 40),
(256, 10343, 64, 50),
(257, 10343, 68, 4),
(258, 10343, 76, 15),
(259, 10344, 4, 35),
(260, 10344, 8, 70),
(261, 10345, 8, 70),
(262, 10345, 19, 80),
(263, 10345, 42, 9),
(264, 10346, 17, 36),
(265, 10346, 56, 20),
(266, 10347, 25, 10),
(267, 10347, 39, 50),
(268, 10347, 40, 4),
(269, 10347, 75, 6),
(270, 10348, 1, 15),
(271, 10348, 23, 25),
(272, 10349, 54, 24),
(273, 10350, 50, 15),
(274, 10350, 69, 18),
(275, 10351, 38, 20),
(276, 10351, 41, 13),
(277, 10351, 44, 77),
(278, 10351, 65, 10),
(279, 10352, 24, 10),
(280, 10352, 54, 20),
(281, 10353, 11, 12),
(282, 10353, 38, 50),
(283, 10354, 1, 12),
(284, 10354, 29, 4),
(285, 10355, 24, 25),
(286, 10355, 57, 25),
(287, 10356, 31, 30),
(288, 10356, 55, 12),
(289, 10356, 69, 20),
(290, 10357, 10, 30),
(291, 10357, 26, 16),
(292, 10357, 60, 8),
(293, 10358, 24, 10),
(294, 10358, 34, 10),
(295, 10358, 36, 20),
(296, 10359, 16, 56),
(297, 10359, 31, 70),
(298, 10359, 60, 80),
(299, 10360, 28, 30),
(300, 10360, 29, 35),
(301, 10360, 38, 10),
(302, 10360, 49, 35),
(303, 10360, 54, 28),
(304, 10361, 39, 54),
(305, 10361, 60, 55),
(306, 10362, 25, 50),
(307, 10362, 51, 20),
(308, 10362, 54, 24),
(309, 10363, 31, 20),
(310, 10363, 75, 12),
(311, 10363, 76, 12),
(312, 10364, 69, 30),
(313, 10364, 71, 5),
(314, 10365, 11, 24),
(315, 10366, 65, 5),
(316, 10366, 77, 5),
(317, 10367, 34, 36),
(318, 10367, 54, 18),
(319, 10367, 65, 15),
(320, 10367, 77, 7),
(321, 10368, 21, 5),
(322, 10368, 28, 13),
(323, 10368, 57, 25),
(324, 10368, 64, 35),
(325, 10369, 29, 20),
(326, 10369, 56, 18),
(327, 10370, 1, 15),
(328, 10370, 64, 30),
(329, 10370, 74, 20),
(330, 10371, 36, 6),
(331, 10372, 20, 12),
(332, 10372, 38, 40),
(333, 10372, 60, 70),
(334, 10372, 72, 42),
(335, 10373, 58, 80),
(336, 10373, 71, 50),
(337, 10374, 31, 30),
(338, 10374, 58, 15),
(339, 10375, 14, 15),
(340, 10375, 54, 10),
(341, 10376, 31, 42),
(342, 10377, 28, 20),
(343, 10377, 39, 20),
(344, 10378, 71, 6),
(345, 10379, 41, 8),
(346, 10379, 63, 16),
(347, 10379, 65, 20),
(348, 10380, 30, 18),
(349, 10380, 53, 20),
(350, 10380, 60, 6),
(351, 10380, 70, 30),
(352, 10381, 74, 14),
(353, 10382, 5, 32),
(354, 10382, 18, 9),
(355, 10382, 29, 14),
(356, 10382, 33, 60),
(357, 10382, 74, 50),
(358, 10383, 13, 20),
(359, 10383, 50, 15),
(360, 10383, 56, 20),
(361, 10384, 20, 28),
(362, 10384, 60, 15),
(363, 10385, 7, 10),
(364, 10385, 60, 20),
(365, 10385, 68, 8),
(366, 10386, 24, 15),
(367, 10386, 34, 10),
(368, 10387, 24, 15),
(369, 10387, 28, 6),
(370, 10387, 59, 12),
(371, 10387, 71, 15),
(372, 10388, 45, 15),
(373, 10388, 52, 20),
(374, 10388, 53, 40),
(375, 10389, 10, 16),
(376, 10389, 55, 15),
(377, 10389, 62, 20),
(378, 10389, 70, 30),
(379, 10390, 31, 60),
(380, 10390, 35, 40),
(381, 10390, 46, 45),
(382, 10390, 72, 24),
(383, 10391, 13, 18),
(384, 10392, 69, 50),
(385, 10393, 2, 25),
(386, 10393, 14, 42),
(387, 10393, 25, 7),
(388, 10393, 26, 70),
(389, 10393, 31, 32),
(390, 10394, 13, 10),
(391, 10394, 62, 10),
(392, 10395, 46, 28),
(393, 10395, 53, 70),
(394, 10395, 69, 8),
(395, 10396, 23, 40),
(396, 10396, 71, 60),
(397, 10396, 72, 21),
(398, 10397, 21, 10),
(399, 10397, 51, 18),
(400, 10398, 35, 30),
(401, 10398, 55, 120),
(402, 10399, 68, 60),
(403, 10399, 71, 30),
(404, 10399, 76, 35),
(405, 10399, 77, 14),
(406, 10400, 29, 21),
(407, 10400, 35, 35),
(408, 10400, 49, 30),
(409, 10401, 30, 18),
(410, 10401, 56, 70),
(411, 10401, 65, 20),
(412, 10401, 71, 60),
(413, 10402, 23, 60),
(414, 10402, 63, 65),
(415, 10403, 16, 21),
(416, 10403, 48, 70),
(417, 10404, 26, 30),
(418, 10404, 42, 40),
(419, 10404, 49, 30),
(420, 10405, 3, 50),
(421, 10406, 1, 10),
(422, 10406, 21, 30),
(423, 10406, 28, 42),
(424, 10406, 36, 5),
(425, 10406, 40, 2),
(426, 10407, 11, 30),
(427, 10407, 69, 15),
(428, 10407, 71, 15),
(429, 10408, 37, 10),
(430, 10408, 54, 6),
(431, 10408, 62, 35),
(432, 10409, 14, 12),
(433, 10409, 21, 12),
(434, 10410, 33, 49),
(435, 10410, 59, 16),
(436, 10411, 41, 25),
(437, 10411, 44, 40),
(438, 10411, 59, 9),
(439, 10412, 14, 20),
(440, 10413, 1, 24),
(441, 10413, 62, 40),
(442, 10413, 76, 14),
(443, 10414, 19, 18),
(444, 10414, 33, 50),
(445, 10415, 17, 2),
(446, 10415, 33, 20),
(447, 10416, 19, 20),
(448, 10416, 53, 10),
(449, 10416, 57, 20),
(450, 10417, 38, 50),
(451, 10417, 46, 2),
(452, 10417, 68, 36),
(453, 10417, 77, 35),
(454, 10418, 2, 60),
(455, 10418, 47, 55),
(456, 10418, 61, 16),
(457, 10418, 74, 15),
(458, 10419, 60, 60),
(459, 10419, 69, 20),
(460, 10420, 9, 20),
(461, 10420, 13, 2),
(462, 10420, 70, 8),
(463, 10420, 73, 20),
(464, 10421, 19, 4),
(465, 10421, 26, 30),
(466, 10421, 53, 15),
(467, 10421, 77, 10),
(468, 10422, 26, 2),
(469, 10423, 31, 14),
(470, 10423, 59, 20),
(471, 10424, 35, 60),
(472, 10424, 38, 49),
(473, 10424, 68, 30),
(474, 10425, 55, 10),
(475, 10425, 76, 20),
(476, 10426, 56, 5),
(477, 10426, 64, 7),
(478, 10427, 14, 35),
(479, 10428, 46, 20),
(480, 10429, 50, 40),
(481, 10429, 63, 35),
(482, 10430, 17, 45),
(483, 10430, 21, 50),
(484, 10430, 56, 30),
(485, 10430, 59, 70),
(486, 10431, 17, 50),
(487, 10431, 40, 50),
(488, 10431, 47, 30),
(489, 10432, 26, 10),
(490, 10432, 54, 40),
(491, 10433, 56, 28),
(492, 10434, 11, 6),
(493, 10434, 76, 18),
(494, 10435, 2, 10),
(495, 10435, 22, 12),
(496, 10435, 72, 10),
(497, 10436, 46, 5),
(498, 10436, 56, 40),
(499, 10436, 64, 30),
(500, 10436, 75, 24),
(501, 10437, 53, 15),
(502, 10438, 19, 15),
(503, 10438, 34, 20),
(504, 10438, 57, 15),
(505, 10439, 12, 15),
(506, 10439, 16, 16),
(507, 10439, 64, 6),
(508, 10439, 74, 30),
(509, 10440, 2, 45),
(510, 10440, 16, 49),
(511, 10440, 29, 24),
(512, 10440, 61, 90),
(513, 10441, 27, 50),
(514, 10442, 11, 30),
(515, 10442, 54, 80),
(516, 10442, 66, 60),
(517, 10443, 11, 6),
(518, 10443, 28, 12)

        };
            foreach (var data in orderDetailData)
            {
                var orderDetail = new OrderDetail
                {
                    OrderId = orderMap[data.Item2].OrderId,
                    ProductId = products[data.Item3 - 1].ProductId,
                    Quantity = data.Item4
                };

                context.OrderDetails.Add(orderDetail);
            }

            await context.SaveChangesAsync();
        }
    }
}
