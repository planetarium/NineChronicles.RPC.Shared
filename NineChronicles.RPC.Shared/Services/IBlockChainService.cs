using System.Collections.Generic;
using MagicOnion;

namespace Nekoyume.Shared.Services
{
    public interface IBlockChainService : IService<IBlockChainService>
    {
        UnaryResult<bool> PutTransaction(byte[] txBytes);

        UnaryResult<long> GetNextTxNonce(byte[] addressBytes);

        UnaryResult<byte[]> GetState(byte[] blockHashBytes, byte[] accountAddressBytes, byte[] addressBytes);
        
        UnaryResult<byte[]> GetStateBySrh(byte[] stateRootHashBytes, byte[] addressBytes);

        UnaryResult<byte[]> GetBalance(byte[] blockHashBytes, byte[] accountBytes, byte[] addressBytes, byte[] currencyBytes);
        
        UnaryResult<byte[]> GetBalanceBySrh(byte[] stateRootHashBytes, byte[] addressBytes, byte[] currencyBytes);

        UnaryResult<byte[]> GetTip();

        UnaryResult<byte[]> GetBlockHash(long blockIndex);

        UnaryResult<bool> SetAddressesToSubscribe(byte[] toByteArray, IEnumerable<byte[]> addressesBytes);

        UnaryResult<bool> IsTransactionStaged(byte[] txidBytes);

        UnaryResult<bool> ReportException(string code, string message);

        UnaryResult<bool> AddClient(byte[] addressByte);

        UnaryResult<bool> RemoveClient(byte[] addressByte);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStates(byte[] blockHashBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStatesBySrh(byte[] stateRootHashBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetStateBulk(byte[] blockHashBytes, byte[] accountBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetStateBulkBySrh(byte[] stateRootHashBytes, IEnumerable<byte[]> addressBytesList);

        UnaryResult<Dictionary<byte[], byte[]>> GetSheets(byte[] blockHashBytes, IEnumerable<byte[]> addressBytesList);
    }
}
