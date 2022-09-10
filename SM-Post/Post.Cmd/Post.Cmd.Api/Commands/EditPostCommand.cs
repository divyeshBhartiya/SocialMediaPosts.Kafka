using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class EditPostCommand : BaseCommand
    {
        public string Message { get; set; }
    }
}
