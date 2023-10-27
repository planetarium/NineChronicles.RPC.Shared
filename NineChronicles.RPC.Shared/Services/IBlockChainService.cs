using System.Collections.Generic;
using MagicOnion;

namespace Nekoyume.Shared.Services
{
    public interface IBlockChainService : IService<IBlockChainService>
    {
        UnaryResult<bool> PutTransaction(byte[] txBytes);

        UnaryResult<long> GetNextTxNonce(byte[] addressBytes);

        UnaryResult<byte[]> GetState(byte[] addressBytes, byte[] accountBytes, byte[] blockHashBytes);

        UnaryResult<byte[]> GetStateByWorldSrh(byte[] addressBytes, byte[] accountBytes, byte[] worldStateRootHashBytes);

        UnaryResult<byte[]> GetStateByAccountSrh(byte[] addressBytes, byte[] accountStateRootHashBytes);
        
        UnaryResult<byte[]> GetBalance(byte[] addressBytes, byte[] currencyBytes, byte[] accountBytes, byte[] blockHashBytes);

        UnaryResult<byte[]> GetBalanceByWorldSrh(byte[] addressBytes, byte[] currencyBytes, byte[] accountBytes, byte[] worldStateRootHashBytes);

        UnaryResult<byte[]> GetBalanceByAccountSrh(byte[] addressBytes, byte[] currencyBytes, byte[] accountStateRootHashBytes);

        UnaryResult<byte[]> GetTip();

        UnaryResult<byte[]> GetBlockHash(long blockIndex);

        UnaryResult<bool> SetAddressesToSubscribe(byte[] toByteArray, IEnumerable<byte[]> addressesBytes);

        UnaryResult<bool> IsTransactionStaged(byte[] txidBytes);

        UnaryResult<bool> ReportException(string code, string message);

        UnaryResult<bool> AddClient(byte[] addressByte);

        UnaryResult<bool> RemoveClient(byte[] addressByte);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStates(IEnumerable<byte[]> addressBytesList, byte[] blockHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetAvatarStatesByWorldSrh(IEnumerable<byte[]> addressBytesList, byte[] worldStateRootHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetStateBulk(IEnumerable<byte[]> addressBytesList, byte[] accountBytes, byte[] blockHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetStateBulkByWorldSrh(IEnumerable<byte[]> addressBytesList, byte[] accountBytes, byte[] worldStateRootHashBytes);

        UnaryResult<Dictionary<byte[], byte[]>> GetStateBulkByAccountSrh(IEnumerable<byte[]> addressBytesList, byte[] accountStateRootHashBytes);
    }
}
