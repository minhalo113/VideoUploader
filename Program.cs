using System;
using System.Data;
using Dapper;
using Npgsql;
using System.Linq;
using DotNetEnv;

public class VideoQueue
{
    public int id {get; set;}
    public string video_url {get; set;}
    public string status {get; set;}
}

class Program
{
    static void Main(string[] args){
        Env.Load();
        string connectionString = "Host=" + Env.GetString("DB_HOST") + ";" +

        "Username=" + Env.GetString("DB_USER") + ";" +

        "Password=" + Env.GetString("DB_PASS") + ";" +

        "Database=" + Env.GetString("DB_NAME") + ";" +

        "Port=" + Env.GetString("DB_PORT") + ";Pooling=true";

        Console.WriteLine("Connecting to dtabase");

        try{
            using (var conn = new NpgsqlConnection(connectionString)){
                conn.Open();
                Console.WriteLine("Connected");

                
            }
        }catch(Exception e){
            Console.WriteLine("Something wrong");
            Console.WriteLine($"Error: {e.Message} {e}");
        }
    }
}