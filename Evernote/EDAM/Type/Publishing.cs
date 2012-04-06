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
  public partial class Publishing : TBase
  {
    private string _uri;
    private NoteSortOrder _order;
    private bool _ascending;
    private string _publicDescription;

    public string Uri
    {
      get
      {
        return _uri;
      }
      set
      {
        __isset.uri = true;
        this._uri = value;
      }
    }

    public NoteSortOrder Order
    {
      get
      {
        return _order;
      }
      set
      {
        __isset.order = true;
        this._order = value;
      }
    }

    public bool Ascending
    {
      get
      {
        return _ascending;
      }
      set
      {
        __isset.ascending = true;
        this._ascending = value;
      }
    }

    public string PublicDescription
    {
      get
      {
        return _publicDescription;
      }
      set
      {
        __isset.publicDescription = true;
        this._publicDescription = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool uri;
      public bool order;
      public bool ascending;
      public bool publicDescription;
    }

    public Publishing() {
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
              Uri = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Order = (NoteSortOrder)iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              Ascending = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              PublicDescription = iprot.ReadString();
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
      TStruct struc = new TStruct("Publishing");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Uri != null && __isset.uri) {
        field.Name = "uri";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Uri);
        oprot.WriteFieldEnd();
      }
      if (__isset.order) {
        field.Name = "order";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)Order);
        oprot.WriteFieldEnd();
      }
      if (__isset.ascending) {
        field.Name = "ascending";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Ascending);
        oprot.WriteFieldEnd();
      }
      if (PublicDescription != null && __isset.publicDescription) {
        field.Name = "publicDescription";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(PublicDescription);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Publishing(");
      sb.Append("Uri: ");
      sb.Append(Uri);
      sb.Append(",Order: ");
      sb.Append(Order);
      sb.Append(",Ascending: ");
      sb.Append(Ascending);
      sb.Append(",PublicDescription: ");
      sb.Append(PublicDescription);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
