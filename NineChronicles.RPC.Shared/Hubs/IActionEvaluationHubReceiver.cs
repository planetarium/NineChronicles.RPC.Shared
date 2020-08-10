namespace Nekoyume.Shared.Hubs
{
    public interface IActionEvaluationHubReceiver
    {
        void OnRender(byte[] evaluation);

        void OnTipChanged(long index);

        void OnReorged(byte[] branchpointHash, byte[] oldTipHash, byte[] newTipHash);
    }
}
