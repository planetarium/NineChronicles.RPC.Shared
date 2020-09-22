namespace Nekoyume.Shared.Hubs
{
    public interface IActionEvaluationHubReceiver
    {
        void OnRender(byte[] evaluation);
        
        void OnUnrender(byte[] evaluation);

        void OnTipChanged(long index);

        void OnReorged(byte[] oldTip, byte[] newTip, byte[] branchpoint);

        void OnReorgEnd(byte[] oldTip, byte[] newTip, byte[] branchpoint);

        void OnException(byte[] encoded);
    }
}
