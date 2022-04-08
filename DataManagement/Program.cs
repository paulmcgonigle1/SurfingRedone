using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SurfingRedone;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SurfsUp12 db = new SurfsUp12();//creating the DB

            using (db)
            {
                //create some objects
                Teacher t1 = new Teacher() { TeacherID = 1, TName = "Andy Irons", Image = "\\images\\Surf-Instructors\\andyIrons.jpg " };
                Teacher t2 = new Teacher() { TeacherID = 2, TName = "Kelly Slater", Image = "\\images\\Surf-Instructors\\kellySlater.jpg " };
                Teacher t3 = new Teacher() { TeacherID = 3, TName = "Rickson Gracie", Image = "\\images\\Surf-Instructors\\ricksonGracie.jpg " };


                Beach b1 = new Beach() { BeachID = 1, BName = "Culdaff", Image = "\\images\\Beaches\\culdaff-beach.jpg" };
                Beach b2 = new Beach() { BeachID = 2, BName = "Ballyliffin", Image = "\\images\\Beaches\\ballyliffinBeach.jpg" };
                Beach b3 = new Beach() { BeachID = 3, BName = "Leenan", Image = "\\images\\Beaches\\Leenan-Beach.jpg" };
                Beach b4 = new Beach() { BeachID = 4, BName = "Tullagh", Image = "\\images\\Beaches\\tullaghBeach.jpg" };
                

                

                

                Board board1 = new Board() { BoardID = 1, BoardName ="Board1", Colour = "Red", Type = "Short", Weight = 70, ImageURL = "\\images\\SurfBoards\\board1.png", Price = 150 };
                Board board2 = new Board() { BoardID = 2, BoardName = "Board2", Colour = "Blue", Type = "Long", Weight = 80, ImageURL = "\\images\\SurfBoards\\board2.png", Price = 200 };
                Board board3 = new Board() { BoardID = 3, BoardName = "Board3", Colour = "White", Type = "Mini", Weight = 60, ImageURL = "\\images\\SurfBoards\\board3.png", Price =250 };
                Board board4 = new Board() { BoardID = 4, BoardName = "Board4", Colour = "Yellow", Type = "Long", Weight = 70, ImageURL = "\\images\\SurfBoards\\long1.jpg", Price = 150 };
                Board board5 = new Board() { BoardID = 5, BoardName = "Board5", Colour = "Brown", Type = "Mini", Weight = 80, ImageURL = "\\images\\SurfBoards\\mini1.jpg", Price = 200 };
                Board board6 = new Board() { BoardID = 6, BoardName = "Board6", Colour = "Brown", Type = "Mini", Weight = 60, ImageURL = "\\images\\SurfBoards\\mini2.jpg", Price = 250 };
                Board board7 = new Board() { BoardID = 7, BoardName = "Board7", Colour = "Green", Type = "Short", Weight = 80, ImageURL = "\\images\\SurfBoards\\short1.jpg", Price = 200 };
                Board board8 = new Board() { BoardID = 8, BoardName = "Board8", Colour = "Green", Type = "Short", Weight = 60, ImageURL = "\\images\\SurfBoards\\short2.jpg", Price = 250 };
                Board board9 = new Board() { BoardID = 8, BoardName = "Board9", Colour = "Blue", Type = "Long", Weight = 90, ImageURL = "\\images\\SurfBoards\\long2.jpg", Price = 250 };


                Lesson lesson1 = new Lesson() { LessonID = 1, Date = DateTime.Now, Length = "1 Hour", Teacher = t1, board = board1, Beach = b1 };


               
                User user1 = new User() { UserID = 1, FirstName = "Paul", Surname = "Mc Gonigle", UserName = "admin", Password = "123", ProfilePic = "\\images\\Profilepics\\paul.jpg", Balance = 1000 };
                user1.Boards.Add(board1);
                user1.Lessons.Add(lesson1);

               
                //add to DB

                db.Teachers.Add(t1);
                db.Teachers.Add(t2);
                db.Teachers.Add(t3);

                Console.WriteLine("Added teams to DB");
                db.Beaches.Add(b1);
                db.Beaches.Add(b2);
                db.Beaches.Add(b3);
                db.Beaches.Add(b4);

                Console.WriteLine("Added Players to DB");

                db.Boards.Add(board1);
                db.Boards.Add(board2);
                db.Boards.Add(board3);
                db.Boards.Add(board4);
                db.Boards.Add(board5);  
                db.Boards.Add(board6);  
                db.Boards.Add(board7);
                   db.Boards.Add(board8);
                db.Boards.Add(board9);
                Console.WriteLine("Added Boards");

                db.Users.Add(user1);
                Console.WriteLine("Added Users");

                db.Lessons.Add(lesson1);
                Console.WriteLine("Added Lessons");


                //save changes

                db.SaveChanges();

                Console.WriteLine("Saved changes to DB");

                Console.ReadLine();
            }
        }
    }
}
