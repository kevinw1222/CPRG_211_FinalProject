using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
/*
namespace CPRG211_FinalProject
{
    public static class Constants
    {
        public const string DatabaseFilename = "TodoSQLite.db3";

        public const SQLiteOpenFlags Flags =
            SQLiteOpenFlags.ReadWrite |   // open the databse in read/write mode
            SQLiteOpenFlags.Create |      // create the database if it doesn't exist
            SQLiteOpenFlags.SharedCache;  // enable multi-thread database access

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
    }

    public class TodoItemDatabase : SQLiteAsyncConnection
    {
        public TodoItemDatabase() : base(Constants.DatabasePath, Constants.Flags)
        { }

        private async Task Init()
        {
            if (TableMappings.FindMapping(typeof(TodoItemDatabase)) is null)
            {
                await CreateTableAsync<TodoItemDatabase>();
            }
        }

        public async Task<List<TodoItemDatabase>> GetItemAsync()
        {
            await Init();
            return await Table<TodoItemDatabase>().ToListAsync();
        }

        public async Task<List<TodoItemDatabase>> GetItemsNotDoneAsync()
        {
            await Init();
            return await Table<TodoItemDatabase>().Where(t => t.Done).ToListAsync();
        }

        public async Task<TodoItemDatabase> GetItemAsync(int id)
        {
            await Init();
            return await Table<TodoItemDatabase>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(TodoItemDatabase item)
        {
            await Init();
            if (item.ID != 0)
                return await UpdateAsync(item);
            else
                return await InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(TodoItemDatabase item)
        {
            await Init();
            return await DeleteAsync(item);
        }
    }

    public partial class TodoItemPage : ContentPage
    {
        TodoItemDatabase database;

        public TodoItemPage(TodoItemDatabase todoItemDatabase)
        {
            InitializeComponent();
            database = todoItemDatabase;
        }

        private async Task OnSaveClicked(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Item.Name))
            {
                await DisplayAlert("name Required", "Please enter a name for the todo item.", "OK");
                return;
            }

            await database.SaveItemAsync(Item);
            await Shell.Current.GoToAsync("..");
        }
    }
}
*/