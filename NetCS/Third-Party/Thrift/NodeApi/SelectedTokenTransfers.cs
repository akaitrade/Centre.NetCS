/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SelectedTokenTransfers : TBase
  {
    private byte[] _tokenAddress;
    private string _tokenName;
    private string _tokenTiker;
    private List<TokenTransfer> _transfers;

    public byte[] TokenAddress
    {
      get
      {
        return _tokenAddress;
      }
      set
      {
        __isset.tokenAddress = true;
        this._tokenAddress = value;
      }
    }

    public string TokenName
    {
      get
      {
        return _tokenName;
      }
      set
      {
        __isset.tokenName = true;
        this._tokenName = value;
      }
    }

    public string TokenTiker
    {
      get
      {
        return _tokenTiker;
      }
      set
      {
        __isset.tokenTiker = true;
        this._tokenTiker = value;
      }
    }

    public List<TokenTransfer> Transfers
    {
      get
      {
        return _transfers;
      }
      set
      {
        __isset.transfers = true;
        this._transfers = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool tokenAddress;
      public bool tokenName;
      public bool tokenTiker;
      public bool transfers;
    }

    public SelectedTokenTransfers() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                TokenAddress = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                TokenName = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                TokenTiker = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.List) {
                {
                  Transfers = new List<TokenTransfer>();
                  TList _list57 = iprot.ReadListBegin();
                  for( int _i58 = 0; _i58 < _list57.Count; ++_i58)
                  {
                    TokenTransfer _elem59;
                    _elem59 = new TokenTransfer();
                    _elem59.Read(iprot);
                    Transfers.Add(_elem59);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("SelectedTokenTransfers");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (TokenAddress != null && __isset.tokenAddress) {
          field.Name = "tokenAddress";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(TokenAddress);
          oprot.WriteFieldEnd();
        }
        if (TokenName != null && __isset.tokenName) {
          field.Name = "tokenName";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(TokenName);
          oprot.WriteFieldEnd();
        }
        if (TokenTiker != null && __isset.tokenTiker) {
          field.Name = "tokenTiker";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(TokenTiker);
          oprot.WriteFieldEnd();
        }
        if (Transfers != null && __isset.transfers) {
          field.Name = "transfers";
          field.Type = TType.List;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Transfers.Count));
            foreach (TokenTransfer _iter60 in Transfers)
            {
              _iter60.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("SelectedTokenTransfers(");
      bool __first = true;
      if (TokenAddress != null && __isset.tokenAddress) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TokenAddress: ");
        __sb.Append(TokenAddress);
      }
      if (TokenName != null && __isset.tokenName) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TokenName: ");
        __sb.Append(TokenName);
      }
      if (TokenTiker != null && __isset.tokenTiker) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TokenTiker: ");
        __sb.Append(TokenTiker);
      }
      if (Transfers != null && __isset.transfers) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Transfers: ");
        __sb.Append(Transfers);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
