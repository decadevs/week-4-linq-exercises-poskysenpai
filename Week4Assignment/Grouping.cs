using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment
{
   
    public class Grouping : IGroupinG
    {
        public void UsingGroupBy()
        {
            var group = ListOfStates.nigeriaStates.GroupBy( s => s.ID ).Select(g => 
            new
            {
                StateId = g.Key,
                states = g.Select(s => s.Name).ToList()

            });

            foreach( var state in group)
            {
                Console.WriteLine("\n");
                //Console.WriteLine($"Group:{state.StateId}");
                Console.WriteLine("---------------------------");


                foreach (var i in state.states)
                {
                    Console.Write(i + " ");
                    

                }
            }
        }
        public void usingjoinmethod()
        {
            var output = ListOfStates.itemlist.Join(ListOfStates.saleslist, i => i.ItemId, s => s.ItemId, (i, s) =>
               new
               {
                   id = i.ItemId,
                   desc = i.ItemDes,
                   quantity = s.Qty
               });

            Console.WriteLine("\n");

            var newTable = new ConsoleTable("id", " Description", "Quantity");
            foreach (var Item in output)
            {
                newTable.AddRow(Item.id, Item.desc, Item.quantity);
            }
            newTable.Write();

        }
        public void UsingGroupJoin()  
        {
            var groupJoin = ListOfStates.state.GroupJoin(ListOfStates.stateList,  //inner sequence
                                s => s.StateLetter, //outerKeySelector 
                                sL => sL.StateLetter,     //innerKeySelector
                                (s, stateGroup) => new // resultSelector 
                                {
                                    State = stateGroup,
                                    StandarFulldName = s.Slogan,
                                    Id = stateGroup.Count()
                                });

            foreach (var item in groupJoin)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"{item.StandarFulldName}:count:{item.Id}");
                Console.WriteLine("-----------------");
                foreach (var stud in item.State)
                    Console.WriteLine(stud.State);
                
            }


        }

    }
}





