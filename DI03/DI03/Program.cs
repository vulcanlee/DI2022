﻿using System;

namespace DI03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class OrderManager
    {
        public void LoadOrder()
        {
            // 1. 建立資料庫連線 (包含寫死的連接字串)
            // 2. 執行 ADO.NET 資料存取 (包含資料篩選)
            // 3. 跑迴圈取得資料 (包含資料格式轉換)
            // 4. 回傳資料
        }
    }
}
