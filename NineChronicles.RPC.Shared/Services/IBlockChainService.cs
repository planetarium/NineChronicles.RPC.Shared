using System.Collections.Generic;
using MagicOnion;

namespace Nekoyume.Shared.Services
{
    public interface IBlockChainService : IService<IBlockChainService>
    {
        UnaryResult<bool> PutTransaction(byte[] txBytes);

        UnaryResult<long> GetNextTxNonce(byte[] addressBytes);

        UnaryResult<byte[]> GetState(byte[] addressBytes, byte[] accountAddressBytes, byte[] blockHashBytes);
        
        UnaryResult<byte[]> GetStateBySrh(byte[] addressBytes, byte[] stateRootHashBytes);

        UnaryResult<byte[]> GetBalance(byte[] addressBytes, byte[] currencyBytes, byte[] accountBytes, byte[] blockHashBytes);
        
        UnaryResult<byte[]> GetBalanceBySrh(byte[] addressBytes, byte[] currencyBytes, byte[] stateRootHashBytes);

        UnaryResult<byte[]> GetTip();

        UnaryResult<byte[]> GetBlockHash(long blockIndex);

        UnaryResult<bool> SetAddressesToSubscribe(byte[] toByteArray, IEnumerable<byte[]> addressesBytes);

        UnaryResult<bool> IsTransactionStaged(byte[] txidBytes);

        UnaryResult<bool> ReportException(string code, string message);

        UnaryResult<bool> AddClient(byte[] addressByte);

        UnaryResult<bool> RemoveClient(byte[] addressByte);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStates(IEnumerable<byte[]> addressBytesList, byte[] blockHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStatesBySrh(IEnumerable<byte[]> addressBytesList, byte[] stateRootHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetStateBulk(IEnumerable<byte[]> addressBytesList, byte[] accountBytes, byte[] blockHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetStateBulkBySrh(IEnumerable<byte[]> addressBytesList, byte[] stateRootHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetSheets(IEnumerable<byte[]> addressBytesList, byte[] blockHashBytes);
    }
}
