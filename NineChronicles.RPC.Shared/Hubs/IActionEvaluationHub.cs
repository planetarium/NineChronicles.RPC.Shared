using MagicOnion;
using System.Threading.Tasks;

namespace Nekoyume.Shared.Hubs
{
    public interface IActionEvaluationHub : IStreamingHub<IActionEvaluationHub, IActionEvaluationHubReceiver>
    {
        Task JoinAsync();

        Task LeaveAsync();

        Task BroadcastRenderAsync(byte[] encoded);

        Task BroadcastUnrenderAsync(byte[] encoded);

        Task UpdateTipAsync(long index);

        Task ReportReorgAsync(byte[] oldTip, byte[] newTip, byte[] branchpoint);
        
        Task ReportReorgEndAsync(byte[] oldTip, byte[] newTip, byte[] branchpoint);

        Task ReportExceptionAsync(byte[] encoded);
    }
}
