﻿extern alias ExcelAdomdClientReference;
using System;
using System.Collections.Generic;
using System.Data;

namespace ADOTabular.AdomdClientWrappers
{
    public class AdomdDataReader : System.Data.IDataReader
    {
        private Microsoft.AnalysisServices.AdomdClient.AdomdDataReader _obj;
        private ExcelAdomdClientReference::Microsoft.AnalysisServices.AdomdClient.AdomdDataReader _objExcel;
        private AdomdType _type = AdomdType.AnalysisServices;
        public AdomdDataReader() { }
        public AdomdDataReader(Microsoft.AnalysisServices.AdomdClient.AdomdDataReader obj)
        {
            _obj = obj;
            
            _type = AdomdType.AnalysisServices;
            
        }
        public AdomdDataReader(ExcelAdomdClientReference::Microsoft.AnalysisServices.AdomdClient.AdomdDataReader obj)
        {
            _objExcel = obj;
            _type = AdomdType.Excel;
        }

        public bool Read()
        {

            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.Read();
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<bool> f = delegate
                {
                    return _objExcel.Read();
                };
                return f();
            }
        }

        public bool NextResult()
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.NextResult();
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<bool> f = delegate
                {
                    return _objExcel.NextResult();
                };
                return f();
            }
        }



        public void Close()
        {
            if (_type == AdomdType.AnalysisServices)
            {
                _obj.Close();
            }
            else
            {
                ExcelAdoMdConnections.VoidDelegate f = delegate
                {
                    _objExcel.Close();
                };
                f();
            }
        }

        public int Depth
        {
            get { if (_type == AdomdType.AnalysisServices)
            {
                return _obj.Depth;
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<int> f = delegate
                {
                    return _objExcel.Depth;
                };
                return f();
            } }
        }

        public DataTable GetSchemaTable()
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetSchemaTable();
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<DataTable> f = delegate
                {
                    return _objExcel.GetSchemaTable();
                };
                return f();
            }
        }

        public bool IsClosed
        {
            get
            {
                if (_type == AdomdType.AnalysisServices)
                {
                    return _obj.IsClosed;
                }
                else
                {
                    ExcelAdoMdConnections.ReturnDelegate<bool> f = delegate
                    {
                        return _objExcel.IsClosed;
                    };
                    return f();
                }
            }
        }


        public int RecordsAffected
        {
            get
            {
                if (_type == AdomdType.AnalysisServices)
                {
                    return _obj.RecordsAffected;
                }
                else
                {
                    ExcelAdoMdConnections.ReturnDelegate<int> f = delegate
                    {
                        return _objExcel.RecordsAffected;
                    };
                    return f();
                }
            }
        }

        public void Dispose()
        {
            if (_type == AdomdType.AnalysisServices)
            {
                _obj.Dispose();
            }
            else
            {
                ExcelAdoMdConnections.VoidDelegate f = delegate
                {
                    _objExcel.Dispose();
                };
                f();
            }
        }

        public int FieldCount
        {
            get
            {
                if (_type == AdomdType.AnalysisServices)
                {
                    return _obj.FieldCount;
                }
                else
                {
                    ExcelAdoMdConnections.ReturnDelegate<int> f = delegate
                    {
                        return _objExcel.FieldCount;
                    };
                    return f();
                }
            }
        }

        public bool GetBoolean(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetBoolean(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<bool> f = delegate
                {
                    return _objExcel.GetBoolean(i);
                };
                return f();
            }
        }

        public byte GetByte(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetByte(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<byte> f = delegate
                {
                    return _objExcel.GetByte(i);
                };
                return f();
            }
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetBytes(i,fieldOffset,buffer,bufferoffset,length);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<long> f = delegate
                {
                    return _objExcel.GetBytes(i, fieldOffset,buffer,bufferoffset,length);
                };
                return f();
            }
        }

        public char GetChar(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetChar(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<char> f = delegate
                {
                    return _objExcel.GetChar(i);
                };
                return f();
            }
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetChars(i, fieldoffset,buffer,bufferoffset, length);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<long> f = delegate
                {
                    return _objExcel.GetChars(i,fieldoffset,buffer,bufferoffset, length);
                };
                return f();
            }
        }

        public IDataReader GetData(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetData(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<IDataReader> f = delegate
                {
                    return _objExcel.GetData(i);
                };
                return f();
            }
        }

        public string GetDataTypeName(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetDataTypeName(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<string> f = delegate
                {
                    return _objExcel.GetDataTypeName(i);
                };
                return f();
            }
        }

        public DateTime GetDateTime(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetDateTime(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<DateTime> f = delegate
                {
                    return _objExcel.GetDateTime(i);
                };
                return f();
            }
        }

        public decimal GetDecimal(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetDecimal(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<decimal> f = delegate
                {
                    return _objExcel.GetDecimal(i);
                };
                return f();
            }
        }

        public double GetDouble(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetDouble(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<double> f = delegate
                {
                    return _objExcel.GetDouble(i);
                };
                return f();
            }
        }

        public Type GetFieldType(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetFieldType(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<Type> f = delegate
                {
                    return _objExcel.GetFieldType(i);
                };
                return f();
            }
        }

        public float GetFloat(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetFloat(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<float> f = delegate
                {
                    return _objExcel.GetFloat(i);
                };
                return f();
            }
        }

        public Guid GetGuid(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetGuid(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<Guid> f = delegate
                {
                    return _objExcel.GetGuid(i);
                };
                return f();
            }
        }

        public short GetInt16(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetInt16(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<short> f = delegate
                {
                    return _objExcel.GetInt16(i);
                };
                return f();
            }
        }

        public int GetInt32(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetInt32(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<int> f = delegate
                {
                    return _objExcel.GetInt32(i);
                };
                return f();
            }
        }

        public long GetInt64(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetInt64(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<long> f = delegate
                {
                    return _objExcel.GetInt64(i);
                };
                return f();
            }
        }

        public string GetName(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetName(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<string> f = delegate
                {
                    return _objExcel.GetName(i);
                };
                return f();
            }
        }

        public int GetOrdinal(string name)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetOrdinal(name);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<int> f = delegate
                {
                    return _objExcel.GetOrdinal(name);
                };
                return f();
            }
        }

        public string GetString(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetString(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<string> f = delegate
                {
                    return _objExcel.GetString(i);
                };
                return f();
            }
        }

        public object GetValue(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetValue(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<object> f = delegate
                {
                    return _objExcel.GetValue(i);
                };
                return f();
            }
        }

        public int GetValues(object[] values)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.GetValues(values);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<int> f = delegate
                {
                    return _objExcel.GetValues(values);
                };
                return f();
            }
        }

        public bool IsDBNull(int i)
        {
            if (_type == AdomdType.AnalysisServices)
            {
                return _obj.IsDBNull(i);
            }
            else
            {
                ExcelAdoMdConnections.ReturnDelegate<bool> f = delegate
                {
                    return _objExcel.IsDBNull(i);
                };
                return f();
            }
        }





        public object this[string name]
        {
            get
            {
                if (_type == AdomdType.AnalysisServices)
                {
                    return _obj[name];
                }
                else
                {
                    ExcelAdoMdConnections.ReturnDelegate<object> f = delegate
                    {
                        return _objExcel[name];
                    };
                    return f();
                }
            }
        }

        public object this[int i]
        {
            get 
            {
                if (_type == AdomdType.AnalysisServices)
                {
                    return _obj[i];
                }
                else
                {
                    ExcelAdoMdConnections.ReturnDelegate<object> f = delegate
                    {
                        return _objExcel[i];
                    };
                    return f();
                }
            } 
        }

        public DataTable ConvertToTable(Dictionary<string,string> formats)
        {
            return ConvertToTable(0, formats);
        }

        public DataTable ConvertToTable(long maxRows)
        {
            return ConvertToTable(maxRows, null);
        }

        public DataTable ConvertToTable()
        {
            return ConvertToTable(0, null);
        }

        public DataTable ConvertToTable(long maxRows, Dictionary<string,string> formats)
        {
            if( maxRows == 0)  maxRows = long.MaxValue;
            long rowCnt = 0;
            
            DataTable dtSchema = this.GetSchemaTable();
            DataTable dt = new DataTable();
            List<DataColumn> listCols = new List<DataColumn>();

            if (dtSchema != null)
            {
                foreach (DataRow drow in dtSchema.Rows)
                {
                    string columnName = System.Convert.ToString(drow["ColumnName"]);
                    DataColumn column = new DataColumn(columnName, (Type)(drow["DataType"]));
                    //column.Unique = (bool)drow["IsUnique"];
                    //column.AllowDBNull = (bool)drow["AllowDBNull"];
                    //column.AutoIncrement = (bool)drow["IsAutoIncrement"];
                    if (formats?.ContainsKey(columnName)??false) column.ExtendedProperties.Add("FormatString", string.Format("{{0:{0}}}" + formats[columnName]));
                    listCols.Add(column);
                    dt.Columns.Add(column);
                }
            }

            // Read rows from DataReader and populate the DataTable
            while (this.Read())
            {
                DataRow dataRow = dt.NewRow();
                for (int i = 0; i < listCols.Count; i++)
                {
                    if (listCols[i].ExtendedProperties.ContainsKey("FormatString"))
                        dataRow[((DataColumn)listCols[i])] = string.Format(listCols[i].ExtendedProperties["FormatString"].ToString() , this[i]);
                    else
                        dataRow[((DataColumn)listCols[i])] = this[i];
                }
                dt.Rows.Add(dataRow);
                rowCnt++;
                if (rowCnt > maxRows) break;
            }
            return dt;  

        }

    }
}
