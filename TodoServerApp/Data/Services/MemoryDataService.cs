using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private static IEnumerable<TaskItem> Tasks { get; } =
		[
			new() {Id = 1, Title="Pet the cat", Description="100 times", CreatedDate=DateTime.Now, FinishDate=DateTime.Today.AddDays(1)},
            new() {Id = 2, Title="Finish this course", Description="Or not?", CreatedDate=DateTime.Now, FinishDate= new DateTime(2024, 12, 31)},
            new() {Id = 3, Title="Philosophy homework", Description="Watch the movie \"Inception\"", CreatedDate=DateTime.Now, FinishDate=new DateTime(2024, 9, 26)},
        ];
        public async Task<IEnumerable<TaskItem>> GetTaskItemsAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(Tasks);
        }
    }
}
