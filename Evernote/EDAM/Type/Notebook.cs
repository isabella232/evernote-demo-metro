/**
 * Autogenerated by Thrift Compiler (0.8.0)
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
using Thrift.Protocol;
using Thrift.Transport;
namespace Evernote.EDAM.Type
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class Notebook : TBase
  {
    private string _guid;
    private string _name;
    private int _updateSequenceNum;
    private bool _defaultNotebook;
    private long _serviceCreated;
    private long _serviceUpdated;
    private Publishing _publishing;
    private bool _published;
    private string _stack;
    private List<long> _sharedNotebookIds;

    public string Guid
    {
      get
      {
        return _guid;
      }
      set
      {
        __isset.guid = true;
        this._guid = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public int UpdateSequenceNum
    {
      get
      {
        return _updateSequenceNum;
      }
      set
      {
        __isset.updateSequenceNum = true;
        this._updateSequenceNum = value;
      }
    }

    public bool DefaultNotebook
    {
      get
      {
        return _defaultNotebook;
      }
      set
      {
        __isset.defaultNotebook = true;
        this._defaultNotebook = value;
      }
    }

    public long ServiceCreated
    {
      get
      {
        return _serviceCreated;
      }
      set
      {
        __isset.serviceCreated = true;
        this._serviceCreated = value;
      }
    }

    public long ServiceUpdated
    {
      get
      {
        return _serviceUpdated;
      }
      set
      {
        __isset.serviceUpdated = true;
        this._serviceUpdated = value;
      }
    }

    public Publishing Publishing
    {
      get
      {
        return _publishing;
      }
      set
      {
        __isset.publishing = true;
        this._publishing = value;
      }
    }

    public bool Published
    {
      get
      {
        return _published;
      }
      set
      {
        __isset.published = true;
        this._published = value;
      }
    }

    public string Stack
    {
      get
      {
        return _stack;
      }
      set
      {
        __isset.stack = true;
        this._stack = value;
      }
    }

    public List<long> SharedNotebookIds
    {
      get
      {
        return _sharedNotebookIds;
      }
      set
      {
        __isset.sharedNotebookIds = true;
        this._sharedNotebookIds = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool guid;
      public bool name;
      public bool updateSequenceNum;
      public bool defaultNotebook;
      public bool serviceCreated;
      public bool serviceUpdated;
      public bool publishing;
      public bool published;
      public bool stack;
      public bool sharedNotebookIds;
    }

    public Notebook() {
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
            if (field.Type == TType.String) {
              Guid = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              UpdateSequenceNum = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Bool) {
              DefaultNotebook = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I64) {
              ServiceCreated = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I64) {
              ServiceUpdated = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Struct) {
              Publishing = new Publishing();
              Publishing.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Bool) {
              Published = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.String) {
              Stack = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.List) {
              {
                SharedNotebookIds = new List<long>();
                TList _list29 = iprot.ReadListBegin();
                for( int _i30 = 0; _i30 < _list29.Count; ++_i30)
                {
                  long _elem31 = 0;
                  _elem31 = iprot.ReadI64();
                  SharedNotebookIds.Add(_elem31);
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

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Notebook");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Guid != null && __isset.guid) {
        field.Name = "guid";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Guid);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.updateSequenceNum) {
        field.Name = "updateSequenceNum";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(UpdateSequenceNum);
        oprot.WriteFieldEnd();
      }
      if (__isset.defaultNotebook) {
        field.Name = "defaultNotebook";
        field.Type = TType.Bool;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(DefaultNotebook);
        oprot.WriteFieldEnd();
      }
      if (__isset.serviceCreated) {
        field.Name = "serviceCreated";
        field.Type = TType.I64;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(ServiceCreated);
        oprot.WriteFieldEnd();
      }
      if (__isset.serviceUpdated) {
        field.Name = "serviceUpdated";
        field.Type = TType.I64;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(ServiceUpdated);
        oprot.WriteFieldEnd();
      }
      if (Publishing != null && __isset.publishing) {
        field.Name = "publishing";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        Publishing.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.published) {
        field.Name = "published";
        field.Type = TType.Bool;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Published);
        oprot.WriteFieldEnd();
      }
      if (Stack != null && __isset.stack) {
        field.Name = "stack";
        field.Type = TType.String;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Stack);
        oprot.WriteFieldEnd();
      }
      if (SharedNotebookIds != null && __isset.sharedNotebookIds) {
        field.Name = "sharedNotebookIds";
        field.Type = TType.List;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, SharedNotebookIds.Count));
          foreach (long _iter32 in SharedNotebookIds)
          {
            oprot.WriteI64(_iter32);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Notebook(");
      sb.Append("Guid: ");
      sb.Append(Guid);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",UpdateSequenceNum: ");
      sb.Append(UpdateSequenceNum);
      sb.Append(",DefaultNotebook: ");
      sb.Append(DefaultNotebook);
      sb.Append(",ServiceCreated: ");
      sb.Append(ServiceCreated);
      sb.Append(",ServiceUpdated: ");
      sb.Append(ServiceUpdated);
      sb.Append(",Publishing: ");
      sb.Append(Publishing== null ? "<null>" : Publishing.ToString());
      sb.Append(",Published: ");
      sb.Append(Published);
      sb.Append(",Stack: ");
      sb.Append(Stack);
      sb.Append(",SharedNotebookIds: ");
      sb.Append(SharedNotebookIds);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
