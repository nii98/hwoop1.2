using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Sources;

namespace Family1
{
    enum Sex { male, female };

    class Person
    {

        //  private bool sex; // male= true female =false
        private Sex sex;
        private string name;
        private Person partner { get; set; }
        private Person dad;
        private Person mom;
        private List<Person> child;

        public Person(string name, Sex sex)
        {
            this.name = name;
            this.sex = sex;
        }


        public string GetPersonName()
        {
            return this.name;
        }

        public string GetPartnerName()
        {

            if (this.partner != null)
            {
                return this.partner.name;
            }
            else {
                return "Not found";
            }
        }
        public Person GetPartner()
        {
            return this.partner;
        }


        public void MarrriedOn(Person married)
        {
            if (this.partner == null)
            {
                this.partner = married;
                married.partner = this;
            }

            else
            {
                this.partner.partner = null;
                this.partner = married;
                married.partner = this;
            }
          
        }


        public void SetChild(Person child)
        {

            if (this.child != null)
            {
                this.child.Add(child);
            }
            if (this.child == null)
            {
                List<Person> children = new List<Person>();
                children.Add(child);
                this.child = children;

            }


            if (this.partner != null)

            {

                if (this.partner.child != null)
                {
                    this.partner.child.Add(child);
                }

                if (this.partner.child == null)

                {
                    List<Person> children = new List<Person>();
                    children.Add(child);
                    this.partner.child = children;

                }

                if (this.partner.sex == Sex.male)
                {
                    child.dad = this.partner;
                }

                if (this.partner.sex == Sex.female)
                {
                    child.mom = this.partner;
                }
            }

            if (this.sex == Sex.male) { child.dad = this; }
            if (this.sex == Sex.female) { child.mom = this; }


        }


        private Person GetDad()
        {
            return this.dad;
        }

        private Person GetMom()
        {
            return this.mom;
        }

        public string GetParentsNames()

        {
            return this.dad.name + " " + this.mom.name;

        }

        private List<Person> GetBrother()
        {
            List<Person> brother_list = new List<Person>();
            if (this.dad != null)

            {
                brother_list.AddRange(this.dad.child);

            }

            if (this.mom != null)
            {
                brother_list.AddRange(this.mom.child);

            }


            brother_list.Remove(this);
            return brother_list;
        }
        private List<Person> FindBloodUncles()
        {
            List<Person> uncle_list = new List<Person>();
            if (this.dad != null) {

                if (this.dad.GetBrother() != null)
                {
                    uncle_list.AddRange(this.dad.GetBrother());
                }
            }
            if (this.mom != null)
            {
                if (this.mom.GetBrother() != null)
                {
                    uncle_list.AddRange(this.mom.GetBrother());
                }

            }

            return uncle_list;
        }

        public List<Person> GetUncles()
        {
            List<Person> listOfUncles = new List<Person>();
            Person LastUncle = null;
            foreach (Person uncles in this.FindBloodUncles())
            {
                listOfUncles.Add(uncles);
                if (uncles.partner != null)
                {
                    listOfUncles.Add(uncles.partner);
                }

                // фильтр
                if (uncles == this.dad || uncles == this.mom)
                {
                    listOfUncles.Remove(uncles);
                    listOfUncles.Remove(uncles.partner);
                }

                if (uncles == LastUncle && (uncles.dad == LastUncle.dad || uncles.mom == LastUncle))
                {

                    listOfUncles.Remove(uncles);
                
                }
                listOfUncles = listOfUncles.GroupBy(x => x.name ).Select(x => x.First()).ToList();
               
            }
            

            return listOfUncles;

        }


        

        public void PrintUncles()
        {
            foreach (Person uncles in this.GetUncles())
            {
                Console.WriteLine(uncles.name);

            }

            
        }


        private List<Person> GetLaws()
        {
            List<Person> laws_list = new List<Person>();
            if (this.partner != null)
            {
                laws_list.Add(this.partner.dad);
                laws_list.Add(this.partner.mom);
            }
            return laws_list;

        }

        public void PrintLaws()
        {

            foreach (Person laws in this.GetLaws())
            {
                Console.WriteLine(laws.name);

            }
        }

        public List<Person> GetCusins()
        {
            //Person LastUncle = null;
            List<Person> cusin_list = new List<Person>();
            List<Person> Uncles_list = this.GetUncles();
            Person LastUncle = null;
            foreach (Person uncle in Uncles_list)
            {
                if (uncle.child != null && LastUncle != uncle.partner) 
                {
                    cusin_list.AddRange(uncle.child);
                    LastUncle = uncle;
                }
            
                               
            }
            return cusin_list;
        }


        
       
        public void PrintCusins()
        {

            foreach (Person cusin in this.GetCusins())
            {
                Console.WriteLine(cusin.name);
            }
        }


        public void PrintChild()
        {
            if (this.child != null)
            {
                foreach (Person child in this.child)
                {
                    Console.WriteLine(child.name);
                }
            }

            else
            {
                Console.WriteLine("not found");

            }
        }
    }

  
}

