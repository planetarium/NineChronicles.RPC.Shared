using System.Collections.Generic;
using MagicOnion;

namespace Nekoyume.Shared.Services
{
    public interface IBlockChainService : IService<IBlockChainService>
    {
        UnaryResult<bool> PutTransaction(byte[] txBytes);

        UnaryResult<long> GetNextTxNonce(byte[] addressBytes);

        UnaryResult<byte[]> GetStateByBlockHash(
            byte[] blockHashBytes, byte[] accountAddressBytes, byte[] addressBytes);

        UnaryResult<byte[]> GetStateByStateRootHash(
            byte[] stateRootHashBytes, byte[] accountAddressBytes, byte[] addressBytes);

        UnaryResult<byte[]> GetBalanceByBlockHash(
            byte[] blockHashBytes, byte[] accountAddressBytes, byte[] addressBytes, byte[] currencyBytes);

        UnaryResult<byte[]> GetBalanceByStateRootHash(
            byte[] stateRootHashBytes, byte[] accountAddressBytes, byte[] addressBytes, byte[] currencyBytes);

        UnaryResult<byte[]> GetTip();

        UnaryResult<byte[]> GetBlockHash(long blockIndex);

        UnaryResult<bool> SetAddressesToSubscribe(byte[] toByteArray, IEnumerable<byte[]> addressesBytes);

        UnaryResult<bool> IsTransactionStaged(byte[] txidBytes);

        UnaryResult<bool> ReportException(string code, string message);

        UnaryResult<bool> AddClient(byte[] addressByte);

        UnaryResult<bool> RemoveClient(byte[] addressByte);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStatesByBlockHash(
            byte[] blockHashBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStatesByStateRootHash(
            byte[] stateRootHashBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetBulkStateByBlockHash(
            byte[] blockHashBytes, byte[] accountAddressBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetBulkStateByStateRootHash(
            byte[] stateRootHashBytes, byte[] accountAddressBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetSheets(byte[] blockHashBytes, IEnumerable<byte[]> addressBytesList);
    }
}
