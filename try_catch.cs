// :) erstes try catch EVER
                    try
                    {
                        cmd.ExecuteNonQuery();
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    catch (Exception)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(item.Game.Name + item.Game.Box.Medium + item.Game.Name.Length);
                        
                    }
