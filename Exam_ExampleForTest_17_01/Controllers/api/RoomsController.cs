using Exam_ExampleForTest_17_01.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exam_ExampleForTest_17_01.Controllers.api
{
    public class RoomsController : ApiController
    {
        public List<Room> RoomList = new List<Room>();
        public static string connString = "Data Source=LAPTOP-P4F5KURV;Initial Catalog=TzagaysHotelDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        // GET: api/Rooms
        public IHttpActionResult Get()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Rooms";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            RoomList.Add(new Room(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetBoolean(3), dr.GetInt32(4)));

                        }
                    }
                    connection.Close();
                    return Ok(new { RoomList });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Rooms/5
        public IHttpActionResult Get(int id)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = $@"SELECT * FROM Rooms where Id ={id}";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Room roomi = new Room(dr.GetInt32(0), dr.GetInt32(1), dr.GetString(2), dr.GetBoolean(3), dr.GetInt32(4));

                            connection.Close();
                            return Ok(new { roomi });
                        }
                    }
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Rooms
        public IHttpActionResult Post([FromBody] Room value)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    string query = $@"INSERT INTO Rooms (RoomNum,Type,isBooked,Price)VALUES({value.RoomNum},'{value.Type}','{value.isBooked}',{value.Price})";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rows = cmd.ExecuteNonQuery();
                    return Ok(new { rows, value });

                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Rooms/5
        public IHttpActionResult Put(int id, [FromBody] Room value)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                conn.Close();
            }
        }

        // DELETE: api/Rooms/5
        public void Delete(int id)
        {
        }
    }
}
