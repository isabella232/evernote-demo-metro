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
namespace Evernote.EDAM.NoteStore
{

  #if !SILVERLIGHT && !NETFX_CORE
  [Serializable]
  #endif
  public partial class SyncChunk : TBase
  {
    private long _currentTime;
    private int _chunkHighUSN;
    private int _updateCount;
    private List<Evernote.EDAM.Type.Note> _notes;
    private List<Evernote.EDAM.Type.Notebook> _notebooks;
    private List<Evernote.EDAM.Type.Tag> _tags;
    private List<Evernote.EDAM.Type.SavedSearch> _searches;
    private List<Evernote.EDAM.Type.Resource> _resources;
    private List<string> _expungedNotes;
    private List<string> _expungedNotebooks;
    private List<string> _expungedTags;
    private List<string> _expungedSearches;
    private List<Evernote.EDAM.Type.LinkedNotebook> _linkedNotebooks;
    private List<string> _expungedLinkedNotebooks;

    public long CurrentTime
    {
      get
      {
        return _currentTime;
      }
      set
      {
        __isset.currentTime = true;
        this._currentTime = value;
      }
    }

    public int ChunkHighUSN
    {
      get
      {
        return _chunkHighUSN;
      }
      set
      {
        __isset.chunkHighUSN = true;
        this._chunkHighUSN = value;
      }
    }

    public int UpdateCount
    {
      get
      {
        return _updateCount;
      }
      set
      {
        __isset.updateCount = true;
        this._updateCount = value;
      }
    }

    public List<Evernote.EDAM.Type.Note> Notes
    {
      get
      {
        return _notes;
      }
      set
      {
        __isset.notes = true;
        this._notes = value;
      }
    }

    public List<Evernote.EDAM.Type.Notebook> Notebooks
    {
      get
      {
        return _notebooks;
      }
      set
      {
        __isset.notebooks = true;
        this._notebooks = value;
      }
    }

    public List<Evernote.EDAM.Type.Tag> Tags
    {
      get
      {
        return _tags;
      }
      set
      {
        __isset.tags = true;
        this._tags = value;
      }
    }

    public List<Evernote.EDAM.Type.SavedSearch> Searches
    {
      get
      {
        return _searches;
      }
      set
      {
        __isset.searches = true;
        this._searches = value;
      }
    }

    public List<Evernote.EDAM.Type.Resource> Resources
    {
      get
      {
        return _resources;
      }
      set
      {
        __isset.resources = true;
        this._resources = value;
      }
    }

    public List<string> ExpungedNotes
    {
      get
      {
        return _expungedNotes;
      }
      set
      {
        __isset.expungedNotes = true;
        this._expungedNotes = value;
      }
    }

    public List<string> ExpungedNotebooks
    {
      get
      {
        return _expungedNotebooks;
      }
      set
      {
        __isset.expungedNotebooks = true;
        this._expungedNotebooks = value;
      }
    }

    public List<string> ExpungedTags
    {
      get
      {
        return _expungedTags;
      }
      set
      {
        __isset.expungedTags = true;
        this._expungedTags = value;
      }
    }

    public List<string> ExpungedSearches
    {
      get
      {
        return _expungedSearches;
      }
      set
      {
        __isset.expungedSearches = true;
        this._expungedSearches = value;
      }
    }

    public List<Evernote.EDAM.Type.LinkedNotebook> LinkedNotebooks
    {
      get
      {
        return _linkedNotebooks;
      }
      set
      {
        __isset.linkedNotebooks = true;
        this._linkedNotebooks = value;
      }
    }

    public List<string> ExpungedLinkedNotebooks
    {
      get
      {
        return _expungedLinkedNotebooks;
      }
      set
      {
        __isset.expungedLinkedNotebooks = true;
        this._expungedLinkedNotebooks = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT && !NETFX_CORE
    [Serializable]
    #endif
    public struct Isset {
      public bool currentTime;
      public bool chunkHighUSN;
      public bool updateCount;
      public bool notes;
      public bool notebooks;
      public bool tags;
      public bool searches;
      public bool resources;
      public bool expungedNotes;
      public bool expungedNotebooks;
      public bool expungedTags;
      public bool expungedSearches;
      public bool linkedNotebooks;
      public bool expungedLinkedNotebooks;
    }

    public SyncChunk() {
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
            if (field.Type == TType.I64) {
              CurrentTime = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              ChunkHighUSN = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              UpdateCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                Notes = new List<Evernote.EDAM.Type.Note>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  Evernote.EDAM.Type.Note _elem2 = new Evernote.EDAM.Type.Note();
                  _elem2 = new Evernote.EDAM.Type.Note();
                  _elem2.Read(iprot);
                  Notes.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                Notebooks = new List<Evernote.EDAM.Type.Notebook>();
                TList _list3 = iprot.ReadListBegin();
                for( int _i4 = 0; _i4 < _list3.Count; ++_i4)
                {
                  Evernote.EDAM.Type.Notebook _elem5 = new Evernote.EDAM.Type.Notebook();
                  _elem5 = new Evernote.EDAM.Type.Notebook();
                  _elem5.Read(iprot);
                  Notebooks.Add(_elem5);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                Tags = new List<Evernote.EDAM.Type.Tag>();
                TList _list6 = iprot.ReadListBegin();
                for( int _i7 = 0; _i7 < _list6.Count; ++_i7)
                {
                  Evernote.EDAM.Type.Tag _elem8 = new Evernote.EDAM.Type.Tag();
                  _elem8 = new Evernote.EDAM.Type.Tag();
                  _elem8.Read(iprot);
                  Tags.Add(_elem8);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.List) {
              {
                Searches = new List<Evernote.EDAM.Type.SavedSearch>();
                TList _list9 = iprot.ReadListBegin();
                for( int _i10 = 0; _i10 < _list9.Count; ++_i10)
                {
                  Evernote.EDAM.Type.SavedSearch _elem11 = new Evernote.EDAM.Type.SavedSearch();
                  _elem11 = new Evernote.EDAM.Type.SavedSearch();
                  _elem11.Read(iprot);
                  Searches.Add(_elem11);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.List) {
              {
                Resources = new List<Evernote.EDAM.Type.Resource>();
                TList _list12 = iprot.ReadListBegin();
                for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                {
                  Evernote.EDAM.Type.Resource _elem14 = new Evernote.EDAM.Type.Resource();
                  _elem14 = new Evernote.EDAM.Type.Resource();
                  _elem14.Read(iprot);
                  Resources.Add(_elem14);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.List) {
              {
                ExpungedNotes = new List<string>();
                TList _list15 = iprot.ReadListBegin();
                for( int _i16 = 0; _i16 < _list15.Count; ++_i16)
                {
                  string _elem17 = null;
                  _elem17 = iprot.ReadString();
                  ExpungedNotes.Add(_elem17);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.List) {
              {
                ExpungedNotebooks = new List<string>();
                TList _list18 = iprot.ReadListBegin();
                for( int _i19 = 0; _i19 < _list18.Count; ++_i19)
                {
                  string _elem20 = null;
                  _elem20 = iprot.ReadString();
                  ExpungedNotebooks.Add(_elem20);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.List) {
              {
                ExpungedTags = new List<string>();
                TList _list21 = iprot.ReadListBegin();
                for( int _i22 = 0; _i22 < _list21.Count; ++_i22)
                {
                  string _elem23 = null;
                  _elem23 = iprot.ReadString();
                  ExpungedTags.Add(_elem23);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.List) {
              {
                ExpungedSearches = new List<string>();
                TList _list24 = iprot.ReadListBegin();
                for( int _i25 = 0; _i25 < _list24.Count; ++_i25)
                {
                  string _elem26 = null;
                  _elem26 = iprot.ReadString();
                  ExpungedSearches.Add(_elem26);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.List) {
              {
                LinkedNotebooks = new List<Evernote.EDAM.Type.LinkedNotebook>();
                TList _list27 = iprot.ReadListBegin();
                for( int _i28 = 0; _i28 < _list27.Count; ++_i28)
                {
                  Evernote.EDAM.Type.LinkedNotebook _elem29 = new Evernote.EDAM.Type.LinkedNotebook();
                  _elem29 = new Evernote.EDAM.Type.LinkedNotebook();
                  _elem29.Read(iprot);
                  LinkedNotebooks.Add(_elem29);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.List) {
              {
                ExpungedLinkedNotebooks = new List<string>();
                TList _list30 = iprot.ReadListBegin();
                for( int _i31 = 0; _i31 < _list30.Count; ++_i31)
                {
                  string _elem32 = null;
                  _elem32 = iprot.ReadString();
                  ExpungedLinkedNotebooks.Add(_elem32);
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
      TStruct struc = new TStruct("SyncChunk");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.currentTime) {
        field.Name = "currentTime";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(CurrentTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.chunkHighUSN) {
        field.Name = "chunkHighUSN";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ChunkHighUSN);
        oprot.WriteFieldEnd();
      }
      if (__isset.updateCount) {
        field.Name = "updateCount";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(UpdateCount);
        oprot.WriteFieldEnd();
      }
      if (Notes != null && __isset.notes) {
        field.Name = "notes";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Notes.Count));
          foreach (Evernote.EDAM.Type.Note _iter33 in Notes)
          {
            _iter33.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Notebooks != null && __isset.notebooks) {
        field.Name = "notebooks";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Notebooks.Count));
          foreach (Evernote.EDAM.Type.Notebook _iter34 in Notebooks)
          {
            _iter34.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Tags != null && __isset.tags) {
        field.Name = "tags";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Tags.Count));
          foreach (Evernote.EDAM.Type.Tag _iter35 in Tags)
          {
            _iter35.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Searches != null && __isset.searches) {
        field.Name = "searches";
        field.Type = TType.List;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Searches.Count));
          foreach (Evernote.EDAM.Type.SavedSearch _iter36 in Searches)
          {
            _iter36.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (Resources != null && __isset.resources) {
        field.Name = "resources";
        field.Type = TType.List;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Resources.Count));
          foreach (Evernote.EDAM.Type.Resource _iter37 in Resources)
          {
            _iter37.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (ExpungedNotes != null && __isset.expungedNotes) {
        field.Name = "expungedNotes";
        field.Type = TType.List;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, ExpungedNotes.Count));
          foreach (string _iter38 in ExpungedNotes)
          {
            oprot.WriteString(_iter38);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (ExpungedNotebooks != null && __isset.expungedNotebooks) {
        field.Name = "expungedNotebooks";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, ExpungedNotebooks.Count));
          foreach (string _iter39 in ExpungedNotebooks)
          {
            oprot.WriteString(_iter39);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (ExpungedTags != null && __isset.expungedTags) {
        field.Name = "expungedTags";
        field.Type = TType.List;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, ExpungedTags.Count));
          foreach (string _iter40 in ExpungedTags)
          {
            oprot.WriteString(_iter40);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (ExpungedSearches != null && __isset.expungedSearches) {
        field.Name = "expungedSearches";
        field.Type = TType.List;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, ExpungedSearches.Count));
          foreach (string _iter41 in ExpungedSearches)
          {
            oprot.WriteString(_iter41);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (LinkedNotebooks != null && __isset.linkedNotebooks) {
        field.Name = "linkedNotebooks";
        field.Type = TType.List;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, LinkedNotebooks.Count));
          foreach (Evernote.EDAM.Type.LinkedNotebook _iter42 in LinkedNotebooks)
          {
            _iter42.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (ExpungedLinkedNotebooks != null && __isset.expungedLinkedNotebooks) {
        field.Name = "expungedLinkedNotebooks";
        field.Type = TType.List;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, ExpungedLinkedNotebooks.Count));
          foreach (string _iter43 in ExpungedLinkedNotebooks)
          {
            oprot.WriteString(_iter43);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SyncChunk(");
      sb.Append("CurrentTime: ");
      sb.Append(CurrentTime);
      sb.Append(",ChunkHighUSN: ");
      sb.Append(ChunkHighUSN);
      sb.Append(",UpdateCount: ");
      sb.Append(UpdateCount);
      sb.Append(",Notes: ");
      sb.Append(Notes);
      sb.Append(",Notebooks: ");
      sb.Append(Notebooks);
      sb.Append(",Tags: ");
      sb.Append(Tags);
      sb.Append(",Searches: ");
      sb.Append(Searches);
      sb.Append(",Resources: ");
      sb.Append(Resources);
      sb.Append(",ExpungedNotes: ");
      sb.Append(ExpungedNotes);
      sb.Append(",ExpungedNotebooks: ");
      sb.Append(ExpungedNotebooks);
      sb.Append(",ExpungedTags: ");
      sb.Append(ExpungedTags);
      sb.Append(",ExpungedSearches: ");
      sb.Append(ExpungedSearches);
      sb.Append(",LinkedNotebooks: ");
      sb.Append(LinkedNotebooks);
      sb.Append(",ExpungedLinkedNotebooks: ");
      sb.Append(ExpungedLinkedNotebooks);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
