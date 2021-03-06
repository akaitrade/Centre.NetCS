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

namespace NodeApiDiag
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class NodeInfoRespone : TBase
  {
    private NodeApi.APIResponse _result;
    private NodeInfo _info;

    public NodeApi.APIResponse Result
    {
      get
      {
        return _result;
      }
      set
      {
        __isset.result = true;
        this._result = value;
      }
    }

    public NodeInfo Info
    {
      get
      {
        return _info;
      }
      set
      {
        __isset.info = true;
        this._info = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool result;
      public bool info;
    }

    public NodeInfoRespone() {
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
              if (field.Type == TType.Struct) {
                Result = new NodeApi.APIResponse();
                Result.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                Info = new NodeInfo();
                Info.Read(iprot);
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
        TStruct struc = new TStruct("NodeInfoRespone");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Result != null && __isset.result) {
          field.Name = "result";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Result.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Info != null && __isset.info) {
          field.Name = "info";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          Info.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("NodeInfoRespone(");
      bool __first = true;
      if (Result != null && __isset.result) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Result: ");
        __sb.Append(Result== null ? "<null>" : Result.ToString());
      }
      if (Info != null && __isset.info) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Info: ");
        __sb.Append(Info== null ? "<null>" : Info.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
