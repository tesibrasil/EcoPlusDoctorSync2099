using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoplusDoctorSync.Helpers
{
    public static class DataBaseHelper
    {
        private static string InsertTrgScript = "ALTER TRIGGER [dbo].[TRG_LOG_UTENTI_INSERT]\r\nON [dbo].[utenti]\r\nAFTER INSERT\r\nAS\r\nBEGIN\r\n    DECLARE @sKeyValue VARCHAR(255)\r\n    SELECT @sKeyValue = CAST(ID AS VARCHAR(255)) from inserted\r\n\r\n    DECLARE @sValoreOld VARCHAR(MAX)\r\n    DECLARE @sValoreNew VARCHAR(MAX)\r\n\r\n    SELECT @sValoreOld = CAST(ID AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(ID AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'ID', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(USERNAME AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(USERNAME AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'USERNAME', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'PASSWORD', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(ID_GRUPPO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(ID_GRUPPO AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'ID_GRUPPO', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(DISABILITATO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(DISABILITATO AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'DISABILITATO', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(SCADENZA_PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(SCADENZA_PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'SCADENZA_PASSWORD', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(DATA_PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(DATA_PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'DATA_PASSWORD', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(DATA_ULTIMO_UTILIZZO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(DATA_ULTIMO_UTILIZZO AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'DATA_ULTIMO_UTILIZZO', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(PRIMO_LOGIN AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(PRIMO_LOGIN AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'PRIMO_LOGIN', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(TIPO_PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(TIPO_PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'TIPO_PASSWORD', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(ELIMINATO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(ELIMINATO AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'ELIMINATO', null, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(OLD_ROWGUID AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(OLD_ROWGUID AS VARCHAR(MAX)) FROM inserted\r\n    IF (@sValoreNew IS NOT NULL AND @sValoreNew <> '')\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'INSERT', 'ID', @sKeyValue, 'OLD_ROWGUID', null, @sValoreNew\r\n\r\nEND";
        private static string UpdateTrgScript = "ALTER TRIGGER [dbo].[TRG_LOG_UTENTI_UPDATE]\r\nON [dbo].[UTENTI]\r\nAFTER UPDATE\r\nAS\r\nBEGIN\r\n    DECLARE @sKeyValue VARCHAR(255)\r\n    SELECT @sKeyValue = CAST(ID AS VARCHAR(255)) from inserted\r\n\r\n    DECLARE @sValoreOld VARCHAR(MAX)\r\n    DECLARE @sValoreNew VARCHAR(MAX)\r\n\r\n    SELECT @sValoreOld = CAST(ID AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(ID AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'ID', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(USERNAME AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(USERNAME AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'USERNAME', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'PASSWORD', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(ID_GRUPPO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(ID_GRUPPO AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'ID_GRUPPO', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(DISABILITATO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(DISABILITATO AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'DISABILITATO', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(SCADENZA_PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(SCADENZA_PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'SCADENZA_PASSWORD', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(DATA_PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(DATA_PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'DATA_PASSWORD', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(DATA_ULTIMO_UTILIZZO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(DATA_ULTIMO_UTILIZZO AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'DATA_ULTIMO_UTILIZZO', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(PRIMO_LOGIN AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(PRIMO_LOGIN AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'PRIMO_LOGIN', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(TIPO_PASSWORD AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(TIPO_PASSWORD AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'TIPO_PASSWORD', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(ELIMINATO AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(ELIMINATO AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'ELIMINATO', @sValoreOld, @sValoreNew\r\n\r\n    SELECT @sValoreOld = CAST(OLD_ROWGUID AS VARCHAR(MAX)) FROM deleted\r\n    SELECT @sValoreNew = CAST(OLD_ROWGUID AS VARCHAR(MAX)) FROM inserted\r\n    IF ((@sValoreOld IS NULL AND @sValoreNew IS NOT NULL) OR (@sValoreOld <> @sValoreNew))\r\n        EXEC sp_Log_InsertRow 'UTENTI', 'UPDATE', 'ID', @sKeyValue, 'OLD_ROWGUID', @sValoreOld, @sValoreNew\r\n\r\nEND";

        //VERIFICA SE A TABELA TEM A COLUNA TESTE_ROWGUID
        public static bool VerificaColuna(SqlConnection connection)
        {
            bool ret = false;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'UTENTI' AND COLUMN_NAME = 'TESTE_ROWGUID'";

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0) 
                { 
                    ret = true;
                }

                return ret;
            }
        }

        //ALTERA A COLUNA DA TABELA DE TESTE_ROWGUID PARA OLD_ROWGUID
        public static void AlterarColuna(SqlConnection connection)
       {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = $"EXEC sp_rename 'UTENTI.TESTE_ROWGUID', 'OLD_ROWGUID', 'COLUMN'";
                cmd.ExecuteNonQuery();
            }
       }

        //VERIFICA SE A TRIGGER ESPECIFICADA EXISTE NO BANDO DE DADOS
        static bool VerificaTrigger(SqlConnection connection, string triggerName)
        {
            bool ret = false;

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = $"SELECT COUNT(*) FROM sys.triggers WHERE name = '{triggerName}'";

                int count = Convert.ToInt32(cmd.ExecuteScalar());
               
                if (count > 0)
                {
                    ret = true;
                }

                return ret;
            }
        }

        //ALTERA A TRIGGER ESPECIFICADA EXISTE NO BANDO DE DADOS
        static void AlterTrigger(SqlConnection connection, string script)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = script;
                cmd.ExecuteNonQuery();
            }
        }

       public static void ReestruturacaoBD(SqlConnection connection)
        {
            AlterarColuna(connection);

            bool bTrigger = VerificaTrigger(connection, "TRG_LOG_UTENTI_INSERT");
            if (bTrigger) 
            {
                AlterTrigger(connection, InsertTrgScript);
            }

            bTrigger = VerificaTrigger(connection, "TRG_LOG_UTENTI_UPDATE");
            if (bTrigger)
            {
                AlterTrigger(connection, UpdateTrgScript);
            }
        }


    }
}
