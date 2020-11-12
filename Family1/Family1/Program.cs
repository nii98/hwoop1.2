using System;
using System.Collections.Generic;

namespace Family1
{
    class Program


    {
        
        
        static void Main(string[] args)
        {
            /* Person human1 = new Person("Bob",Sex.male);
             Person human2 = new Person("Helena", Sex.female);
             Person human5 = new Person("Karl", Sex.male);
             Person human4 = new Person("Sara", Sex.female);
             Person human3 = new Person("Dave", Sex.male );
             Person human6 = new Person("Jonh", Sex.male);
             Person human7 = new Person("Mary", Sex.female );
             Person human8 = new Person("Derek", Sex.male);
             Person human9 = new Person("Giny", Sex.female);
             Person human10 = new Person("Liza", Sex.female);
             Person human11 = new Person("Eric" , Sex.male);

             // браки
             human1.MarrriedOn(human2);
            // human3.MarrriedOn(human4);
             human6.MarrriedOn(human7);
             human8.MarrriedOn(human9);



             // Дети
             human8.SetChild(human11);
             human6.SetChild(human10);
             human3.SetChild(human8);
             human3.MarrriedOn(human4);
             human4.SetChild(human6);

             human1.SetChild(human3);

             human1.MarrriedOn(human2);


             //вывод
           //  Console.WriteLine(human11.GetPersonName());
            // Console.WriteLine(human11.GetParentsNames());
             // human11.PrintUncles();
             // human11.PrintCusins();
             // human7.PrintLaws();

               // Console.WriteLine(  human6.GetPartnerName());


            human11.PrintUncles();

             //Console.WriteLine(human1.GetPartnerName());

            // human3.PrintChild();
            */
            // Test1
            /* Person me = new Person("Bob", Sex.male);
             Person father = new Person("Jack", Sex.male);
             Person mother = new Person("Alice", Sex.female);
             Person grandfather_by_father_side = new Person("Joe", Sex.male);
             Person uncle_by_father_side_1 = new Person("John", Sex.male);
             Person uncle_by_father_side_2 = new Person("Peter", Sex.male);
             Person grandfather_by_mother_side = new Person("Jerry", Sex.male);
             Person uncle_by_mother_side_1 = new Person("Tom", Sex.male);
             father.MarrriedOn(mother);
             father.SetChild(me);
             grandfather_by_father_side.SetChild(father);
             grandfather_by_father_side.SetChild(uncle_by_father_side_1);
             grandfather_by_father_side.SetChild(uncle_by_father_side_2);
             grandfather_by_mother_side.SetChild(mother);
             grandfather_by_mother_side.SetChild(uncle_by_mother_side_1);
             Person tetya1 = new Person("Vera", Sex.male);

             uncle_by_father_side_1.MarrriedOn(tetya1);


             me.PrintUncles();
             */
            // Test 2
            /*
            Person me = new Person("Bob", Sex.male);
            Person father = new Person("Jack", Sex.male);
            Person mother = new Person("Alice", Sex.female);
            Person grandfather_by_father_side = new Person("Joe", Sex.male);
            Person uncle_by_father_side_1 = new Person("John", Sex.male);
            Person uncle_by_father_side_2 = new Person("Peter", Sex.male);
            Person grandmother_by_mother_side = new Person("Jane", Sex.female);
            Person uncle_by_mother_side_1 = new Person("Tom", Sex.male);
            father.MarrriedOn(mother);
            father.SetChild(me);
            grandfather_by_father_side.SetChild(father);
            grandfather_by_father_side.SetChild(uncle_by_father_side_1);
            grandfather_by_father_side.SetChild(uncle_by_father_side_2);
            grandmother_by_mother_side.SetChild(mother);
            grandmother_by_mother_side.SetChild(uncle_by_mother_side_1);
            me.PrintUncles();
            */

            // test 3 
            //Person me = new Person("Bob", Sex.male);
            //me.PrintUncles();

            //test4
            Person me = new Person("Bob", Sex.male);
            Person father = new Person("Jack", Sex.male);
            Person mother = new Person("Alice", Sex.female);
            Person grandfather_by_father_side = new Person("Joe", Sex.male);
            Person grandmother_by_father_side = new Person("Mary", Sex.female);
            Person uncle_by_father_side_1 = new Person("John", Sex.male);
            Person uncle_by_father_side_2 = new Person("Peter", Sex.male);
            Person grandmother_by_mother_side = new Person("Jane", Sex.female);
            Person uncle_by_mother_side_1 = new Person("Tom", Sex.male);
            
            father.MarrriedOn(mother);
            father.SetChild(me);
            grandfather_by_father_side.MarrriedOn(grandmother_by_father_side);
            grandfather_by_father_side.SetChild(father);
            grandfather_by_father_side.SetChild(uncle_by_father_side_1);
            grandfather_by_father_side.SetChild(uncle_by_father_side_2);
            grandmother_by_mother_side.SetChild(mother);
            grandmother_by_mother_side.SetChild(uncle_by_mother_side_1);
            
            me.PrintUncles();
        }
    }
}
