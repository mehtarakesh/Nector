/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace Apache.Cassandra
{

  [Serializable]
  public partial class ColumnOrSuperColumn : TBase
  {
    private Column _column;
    private SuperColumn _super_column;
    private CounterColumn _counter_column;
    private CounterSuperColumn _counter_super_column;

    public Column Column
    {
      get
      {
        return _column;
      }
      set
      {
        __isset.column = true;
        this._column = value;
      }
    }

    public SuperColumn Super_column
    {
      get
      {
        return _super_column;
      }
      set
      {
        __isset.super_column = true;
        this._super_column = value;
      }
    }

    public CounterColumn Counter_column
    {
      get
      {
        return _counter_column;
      }
      set
      {
        __isset.counter_column = true;
        this._counter_column = value;
      }
    }

    public CounterSuperColumn Counter_super_column
    {
      get
      {
        return _counter_super_column;
      }
      set
      {
        __isset.counter_super_column = true;
        this._counter_super_column = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool column;
      public bool super_column;
      public bool counter_column;
      public bool counter_super_column;
    }

    public ColumnOrSuperColumn() {
    }

    public void Read (TProtocol iprot)
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
              Column = new Column();
              Column.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              Super_column = new SuperColumn();
              Super_column.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              Counter_column = new CounterColumn();
              Counter_column.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Struct) {
              Counter_super_column = new CounterSuperColumn();
              Counter_super_column.Read(iprot);
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ColumnOrSuperColumn");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Column != null && __isset.column) {
        field.Name = "column";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        Column.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Super_column != null && __isset.super_column) {
        field.Name = "super_column";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Super_column.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Counter_column != null && __isset.counter_column) {
        field.Name = "counter_column";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        Counter_column.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Counter_super_column != null && __isset.counter_super_column) {
        field.Name = "counter_super_column";
        field.Type = TType.Struct;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        Counter_super_column.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ColumnOrSuperColumn(");
      sb.Append("Column: ");
      sb.Append(Column== null ? "<null>" : Column.ToString());
      sb.Append(",Super_column: ");
      sb.Append(Super_column== null ? "<null>" : Super_column.ToString());
      sb.Append(",Counter_column: ");
      sb.Append(Counter_column== null ? "<null>" : Counter_column.ToString());
      sb.Append(",Counter_super_column: ");
      sb.Append(Counter_super_column== null ? "<null>" : Counter_super_column.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
