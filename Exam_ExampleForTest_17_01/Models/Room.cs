using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_ExampleForTest_17_01.Models
{
    public class Room
    {
        public Room(int id, int roomNum, string type, bool isBooked, int price)
        {
            Id = id;
            RoomNum = roomNum;
            Type = type;
            this.isBooked = isBooked;
            Price = price;
        }

        public int Id { get; set; }
        public int RoomNum { get; set; }
        public string Type { get; set; }


        public bool isBooked { get; set; }
        public int Price { get; set; }

        public Room() { }
    }

}