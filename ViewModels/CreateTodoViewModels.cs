using MinimalApi.Models;
using Flunt.Notifications;
using Flunt.Validations;

namespace MinimalApi.ViewModels
{
    public class CreateTodoViewModels : Notifiable<Notification>
    {
        public CreateTodoViewModels(string title) => this.Title = title;

        public string Title { get; set; }

        public Todo MapTo()
        {
            var contract = new Contract<Notification>()
                .Requires()
                .IsNotNull(Title, "Informe o título da tarefa")
                .IsGreaterThan(Title.Length, 5, "O título deve ter no mínimo 5 caracteres");

            AddNotifications(contract);

            return new Todo(Guid.NewGuid(), Title, false);
        }
    }
}
