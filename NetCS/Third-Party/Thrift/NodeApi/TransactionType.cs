/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

namespace NodeApi
{
  public enum TransactionType
  {
    TT_Transfer = 0,
    TT_ContractDeploy = 1,
    TT_ContractCall = 2,
    TT_ContractState = 3,
    TT_ContractReplenish = 4,
    TT_TokenDeploy = 5,
    TT_TokenTransfer = 6,
    TT_Delegation = 7,
    TT_RevokeDelegation = 8,
    TT_Hold = 9,
    TT_Release = 10,
    TT_CancelHold = 11,
    TT_DelayedTransfer = 12,
    TT_UpdateBootstrapList = 13,
    TT_UpdateSettings = 14,
    TT_Malformed = 15,
    TT_ContractEmitted = 16,
    TT_Utility = 17,
    TT_Other = 18,
  }
}
