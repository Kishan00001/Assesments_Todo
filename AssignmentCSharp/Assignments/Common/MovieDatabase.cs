using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Assignments.Common
{
    internal class MovieDatabase : IMovieDatabase
    {
        static List<Movie> _list = new List<Movie>();
        public Movie this[int index] => throw new System.NotImplementedException();
        public int Count => throw new System.NotImplementedException();
        int IMovieDatabase.Count => throw new NotImplementedException();
        Movie IMovieDatabase.this[int index] => throw new NotImplementedException();

        private static readonly string fileName = ConfigurationManager.AppSettings["movieCSVFile"];
        public static void MovieMenuDriven()
        {
            bool condition = true;
            do
            {
                Console.WriteLine("\tMENU \n************************\nTo add new movie : Press N\nTo update a movie : Press U\nTo delete a movie : Press D\nTo find a movie : Press F\nTo print all the movie: Press A\nPS: Any other key implies to exit");
                string opt = Console.ReadLine().ToUpper();
                switch (opt)
                {
                    case "N":
                      new MovieDatabase().AddingMovie();
                        break;

                    case "U":
                        int id = utilities.GetInteger("Enter the id of the Movie to get updated");
                        var foundRec = _list.Find((temp) => temp.MovieId == id);
                        new MovieDatabase().Updating(id, foundRec);
                        break;

                    case "D":
                        int id2 = utilities.GetInteger("Enter the id of the movie to be deleted");
                        new MovieDatabase().Deleting(id2);
                        break;

                    case "F": int id3 = utilities.GetInteger("Enter the id to find a movie");
                        FindMovie(id3);
                        break;

                    case "A":PrintAllMovies();
                        break;

                    default:
                        condition = false;
                        break;
                }

            } while (condition);
        }

        private static void PrintAllMovies()
        {
            var records = readAllRecords(fileName);
            foreach (var mov in records)
            {
                printDetails(mov);
            }
        }

        private static void FindMovie(int id)
        {
            _list = readAllRecords(fileName);
            var foundRec = _list.Find(delegate (Movie temp)
            {
                return temp.MovieId == id;
            });
            if (foundRec != null)
            {
                printDetails(foundRec);
            }
            //throw new NotImplementedException();
        }

        public void AddingMovie()
        {
            Console.WriteLine("Enter the movie details to be added...");
            int id = utilities.GetInteger("Enter the Movie Id to be added");
            string name = utilities.GetString("Enter the Movie Name:");
            string genre = utilities.GetString("Enter Movie Genre");
            int year = utilities.GetInteger("Enter Movie Release Year");
            string director = utilities.GetString("Enter Movie Director Name");
            int duration = utilities.GetInteger("Enter the duration of the movie in minutes");
            Movie movie = new Movie(id,name, genre, year, director, duration);
            _list.Add(movie);
            var line = $"{id},{name},{genre},{year},{director},{duration}\n";
            File.AppendAllText(fileName, line);
            Console.WriteLine("New movie added successfully");
        }
        public void Updating(int id, Movie mov)
        {
            _list = readAllRecords(fileName);
            var foundRec = _list.Find((temp) => temp.MovieId == id);
            if (foundRec != null)
            {
                int choice = utilities.GetInteger("Enter Property to update: 1 for MovieId, 2 for MovieName, 3 for MovieGenre, 4 for MovieYear, 5 for MovieDirector, 6 for MovieDuration ");
                switch (choice)
                {
                    case 1:
                        int uid = utilities.GetInteger("Enter Movie Id to update");
                        _list[_list.IndexOf(foundRec)].MovieId = uid;
                        //foundRec.MovieId = uid;
                        Console.WriteLine("Movie ID updated successfully");
                        break;
                    case 2:
                        string uname = utilities.GetString("Enter Movie Name to update");
                        _list[_list.IndexOf(foundRec)].MovieName = uname;
                        //foundRec.MovieName = uname;
                        Console.WriteLine("Movie Name updated successfully");
                        break;
                    case 3:
                        string ugen = utilities.GetString("Enter Movie Genre to update");
                        _list[_list.IndexOf(foundRec)].Genre = ugen;
                        //foundRec.Genre = ugen;
                        Console.WriteLine("Movie Genre updated successfully");
                        break;
                    case 4:
                        int uyear = utilities.GetInteger("Enter Movie year to update");
                        _list[_list.IndexOf(foundRec)].MovieYear = uyear;
                        //foundRec.MovieYear = uyear;
                        Console.WriteLine("Movie Year updated successfully");
                        break;
                    case 5:
                        string udir = utilities.GetString("Enter Movie Director to update");
                        _list[_list.IndexOf(foundRec)].Director = udir;
                        //foundRec.Director =udir;
                        Console.WriteLine("Movie Director updated successfully");
                        break;
                    case 6:
                        int udur = utilities.GetInteger("Enter Movie Durations to update");
                        _list[_list.IndexOf(foundRec)].Duration = udur;
                        //foundRec.Duration = udur;
                        Console.WriteLine("Movie Duration updated successfully");
                        break;
                    default:
                        Console.WriteLine("Invalid Option Choosen");
                        break;
                }
                File.Delete(fileName);
                bulkInsertRecord(_list);
            }
            else throw new Exception("Invalid Movie ID entered");   
        }
        private static void bulkInsertRecord(List<Movie> records)
        {
            foreach (var mov in records)
                writeEmpRecordToFile(mov);
            Console.WriteLine("Movie List Updated");
        }
        private static void writeEmpRecordToFile(Movie mov)
        {
            var line = $"{mov.MovieId},{mov.MovieName},{mov.Genre},{mov.MovieYear},{mov.Director},{mov.Duration}\n";
            File.AppendAllText(fileName, line);// will be saved in "C:\Users\kkumarmaharana\source\repos\DotnetTraining\Proj1-SampleConApp\bin\Debug\EmpData.csv"
        }

        private static List<Movie> readAllRecords(string filename)
        {
            List<Movie> empList = new List<Movie>();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                var emp = new Movie { MovieId = int.Parse(words[0]), MovieName = words[1], Genre = words[2], MovieYear = int.Parse(words[3]),Director = words[4],Duration=int.Parse(words[5]) };
                empList.Add(emp);
            }
            return empList;
        }

        public void Deleting(int id)
        {
            var records = readAllRecords(fileName);
            for (int i = 0; i < records.Count; i++)
            {
                if (records[i].MovieId == id)
                {
                    records.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("The movie was deleted");
            File.Delete(fileName);

            bulkInsertRecord(records);
        }
        private static void printDetails(Movie mov)
        {
            Console.WriteLine("The Movie Details Of The Movie Id "+mov.MovieId+" are: ");
            Console.WriteLine("The Movie Name is:  '"+mov.MovieName+"' directed by: "+mov.Director);
            Console.WriteLine("The Movie Genre is: "+mov.Genre);
            Console.WriteLine("It released in: "+mov.MovieYear+ " and Its duration is: "+mov.Duration+" minutes\n");
        }
        IEnumerator<Movie> IEnumerable<Movie>.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
 }