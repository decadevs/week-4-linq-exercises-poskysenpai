using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Assignment
{
    class State
    {
        public string Name { get; set; }
        public string Capital { get; set; }
    }
    class Item
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }
    class StateInformation
    {
        public string State { get; set; }
        public string Capital { get; set; }
        public char StateLetter { get; set; }
    }
    class StateInfo
    {
        public char StateLetter { get; set; }
        public string Slogan { get; set; }
    }
    class Sales
    {
        public int ItemId { get; set; }
        public int InvNo { get; set; }
        public int Qty { get; set; }
    }
    class GroupState
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public GroupState(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
     internal class ListOfStates
    {
        
        public static  List<GroupState> nigeriaStates = new List<GroupState>
        {
            new GroupState(1, "Abia"),
            new GroupState(2, "Adamawa"),
            new GroupState(3, "Akwa Ibom"),
            new GroupState(4, "Anambra"),
            new GroupState(5, "Bauchi"),
            new GroupState(6, "Bayelsa"),
            new GroupState(7, "Benue"),
            new GroupState(8, "Borno"),
            new GroupState(9, "Cross River"),
            new GroupState(10, "Delta"),
            new GroupState(11, "Ebonyi"),
            new GroupState(12, "Edo"),
            new GroupState(1, "Ekiti"),
            new GroupState(2, "Enugu"),
            new GroupState(3, "Gombe"),
            new GroupState(4, "Imo"),
            new GroupState(5, "Jigawa"),
            new GroupState(6, "Kaduna"),
            new GroupState(7, "Kano"),
            new GroupState(8, "Katsina"),
            new GroupState(9, "Kebbi"),
            new GroupState(10, "Kogi"),
            new GroupState(11, "Kwara"),
            new GroupState(12, "Lagos"),
            new GroupState(1, "Nasarawa"),
            new GroupState(2, "Niger"),
            new GroupState(3, "Ogun"),
            new GroupState(4, "Ondo"),
            new GroupState(5, "Osun"),
            new GroupState(6, "Oyo"),
            new GroupState(7, "Plateau"),
            new GroupState(8, "Rivers"),
            new GroupState(9, "Sokoto"),
            new GroupState(10, "Taraba"),
            new GroupState(11, "Yobe"),
            new GroupState(12, "Zamfara")
        };

        public static List<StateInformation> stateList = new List<StateInformation>
        {
            new StateInformation { State = "Abia", Capital = "Umuahia", StateLetter = 'A' },
            new StateInformation { State = "Adamawa", Capital = "Yola", StateLetter = 'A' },
            new StateInformation { State = "Akwa Ibom", Capital = "Uyo", StateLetter = 'A' },
            new StateInformation { State = "Anambra", Capital = "Awka", StateLetter = 'A' },
            new StateInformation { State = "Bauchi", Capital = "Bauchi", StateLetter = 'B' },
            new StateInformation { State = "Bayelsa", Capital = "Yenagoa", StateLetter = 'B' },
            new StateInformation { State = "Benue", Capital = "Makurdi", StateLetter = 'B' },
            new StateInformation { State = "Borno", Capital = "Maiduguri", StateLetter = 'B' },
            new StateInformation { State = "Cross River", Capital = "Calabar", StateLetter = 'C' },
            new StateInformation { State = "Delta", Capital = "Asaba", StateLetter = 'D' },
            new StateInformation { State = "Ebonyi", Capital = "Abakaliki", StateLetter = 'E' },
            new StateInformation { State = "Edo", Capital = "Benin City", StateLetter = 'E' },
            new StateInformation { State = "Ekiti", Capital = "Ado-Ekiti", StateLetter = 'E' },
            new StateInformation { State = "Enugu", Capital = "Enugu", StateLetter = 'E' },
            new StateInformation { State = "Gombe", Capital = "Gombe", StateLetter = 'G' },
            new StateInformation { State = "Imo", Capital = "Owerri", StateLetter = 'I' },
            new StateInformation { State = "Jigawa", Capital = "Dutse", StateLetter = 'J' },
            new StateInformation { State = "Kaduna", Capital = "Kaduna", StateLetter = 'K' },
            new StateInformation { State = "Kano", Capital = "Kano", StateLetter = 'K' },
            new StateInformation { State = "Katsina", Capital = "Katsina", StateLetter = 'K' },
            new StateInformation { State = "Kebbi", Capital = "Birnin Kebbi", StateLetter = 'K' },
            new StateInformation { State = "Kogi", Capital = "Lokoja", StateLetter = 'K' },
            new StateInformation { State = "Kwara", Capital = "Ilorin", StateLetter = 'K' },
            new StateInformation { State = "Lagos", Capital = "Ikeja", StateLetter = 'L' },
            new StateInformation { State = "Nasarawa", Capital = "Lafia", StateLetter = 'N' },
            new StateInformation { State = "Niger", Capital = "Minna", StateLetter = 'N' },
            new StateInformation { State = "Ogun", Capital = "Abeokuta", StateLetter = 'O' },
            new StateInformation { State = "Ondo", Capital = "Akure", StateLetter = 'O' },
            new StateInformation { State = "Osun", Capital = "Osogbo", StateLetter = 'O' },
            new StateInformation { State = "Oyo", Capital = "Ibadan", StateLetter = 'O' },
            new StateInformation { State = "Plateau", Capital = "Jos", StateLetter = 'P' },
            new StateInformation { State = "Rivers", Capital = "Port Harcourt", StateLetter = 'R' },
            new StateInformation { State = "Sokoto", Capital = "Sokoto", StateLetter = 'S' },
            new StateInformation { State = "Taraba", Capital = "Jalingo", StateLetter = 'T' },
            new StateInformation { State = "Yobe", Capital = "Damaturu", StateLetter = 'Y' },
            new StateInformation { State = "Zamfara", Capital = "Gusau", StateLetter = 'Z' }
        };

        public static List<StateInfo> state = new List<StateInfo>
        {
            new StateInfo { StateLetter = 'A', Slogan = "Group A" },
            new StateInfo { StateLetter = 'B', Slogan = "Group B"  },
            new StateInfo { StateLetter = 'C', Slogan = "Group C"  },
            new StateInfo { StateLetter = 'D', Slogan = "Group D"  },
            new StateInfo { StateLetter = 'E', Slogan = "Group E"  },
            new StateInfo { StateLetter = 'G', Slogan = "Group G" },
            new StateInfo { StateLetter = 'I', Slogan = "Group I"  },
            new StateInfo { StateLetter = 'J', Slogan = "Group J"  },
            new StateInfo { StateLetter = 'K', Slogan = "Group K"  },
            new StateInfo { StateLetter = 'L', Slogan = "Group L"  },
            new StateInfo { StateLetter = 'N', Slogan = "Group N"  },
            new StateInfo { StateLetter = 'O', Slogan = "Group O"  },
            new StateInfo { StateLetter = 'P', Slogan = "Group P"  },
            new StateInfo { StateLetter = 'R', Slogan = "Group R"  },
            new StateInfo { StateLetter = 'S', Slogan = "Group S"  },
            new StateInfo { StateLetter = 'T', Slogan = "Group T"  },
            new StateInfo { StateLetter = 'Y', Slogan = "Group Y"  },
            new StateInfo { StateLetter = 'Z', Slogan = "Group Z"  }
        };

        public static List<Item> itemlist = new List<Item>

                {

                new Item { ItemId = 1, ItemDes = "bag" },

                new Item { ItemId = 2, ItemDes = "pen" },

                new Item  { ItemId = 3, ItemDes = "book " },

                new Item  { ItemId = 4, ItemDes = "shoe " },

                new Item  { ItemId = 5, ItemDes = "pin " }

                };

        public static List<Sales> saleslist = new List<Sales>
                {

                new Sales{ InvNo=1, ItemId = 3, Qty = 10 },

                new Sales{ InvNo=2, ItemId = 2, Qty = 20 },

                new Sales{ InvNo=3, ItemId= 3, Qty = 500 },

                new Sales{ InvNo=4, ItemId = 4, Qty = 20 },

                new Sales{ InvNo=5, ItemId = 3, Qty = 100 },

                new Sales{ InvNo=6, ItemId= 1, Qty = 50 }

                };

    }



    
}


