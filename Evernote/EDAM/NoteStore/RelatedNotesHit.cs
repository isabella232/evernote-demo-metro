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
namespace Evernote.EDAM.NoteStore
{

  #if !NETFX_CORE
  [Serializable]
  #endif
  public partial class RelatedNotesHit : TBase
  {
    private Evernote.EDAM.Type.Note _note;
    private string _explanation;
    private double _score;

    public Evernote.EDAM.Type.Note Note
    {
      get
      {
        return _note;
      }
      set
      {
        __isset.note = true;
        this._note = value;
      }
    }

    public string Explanation
    {
      get
      {
        return _explanation;
      }
      set
      {
        __isset.explanation = true;
        this._explanation = value;
      }
    }

    public double Score
    {
      get
      {
        return _score;
      }
      set
      {
        __isset.score = true;
        this._score = value;
      }
    }


    public Isset __isset;
    #if !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool note;
      public bool explanation;
      public bool score;
    }

    public RelatedNotesHit() {
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
              Note = new Evernote.EDAM.Type.Note();
              Note.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Explanation = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Double) {
              Score = iprot.ReadDouble();
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
      TStruct struc = new TStruct("RelatedNotesHit");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Note != null && __isset.note) {
        field.Name = "note";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        Note.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Explanation != null && __isset.explanation) {
        field.Name = "explanation";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Explanation);
        oprot.WriteFieldEnd();
      }
      if (__isset.score) {
        field.Name = "score";
        field.Type = TType.Double;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(Score);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RelatedNotesHit(");
      sb.Append("Note: ");
      sb.Append(Note== null ? "<null>" : Note.ToString());
      sb.Append(",Explanation: ");
      sb.Append(Explanation);
      sb.Append(",Score: ");
      sb.Append(Score);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
