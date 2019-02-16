using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BHISApi.Custom.DatabaseHelpers;
using BHISApi.Custom.Models.History;

namespace BHISApi.Custom.DatabaseRepository
{
    public class HistoryRepository
    {
        public async Task<DatabaseResult<PatientCase>> GetPatientCases(int IdPatient) 
            => (await new Query().Select<PatientCase>("[GetPatientCase] @Id", new { Id = IdPatient }));

        public async Task<DatabaseSingleResult<dynamic>> GetVisitOrigin(int Id)
            => (await new Query().SelectSingle<dynamic>("[GetMedicalPacientCaseOrigin] @Id", new { Id = Id }));

        public async Task<DatabaseResult<dynamic>> GetVisitExamination(int Id)
            => (await new Query().Select<dynamic>("[GetExaminations] @IdVisit", new { IdVisit = Id }));

        public async Task<DatabaseResult<dynamic>> GetVisitDiagnose(int Id)
          => (await new Query().Select<dynamic>("[GetDiagnoses] @IdVisit", new { IdVisit = Id }));

        public async Task<DatabaseResult<dynamic>> GetVisitTherapy(int Id)
          => (await new Query().Select<dynamic>("[GetDrugs] @IdVisit", new { IdVisit = Id }));

        public async Task<DatabaseSingleResult<dynamic>> GetVisitConclusion(int Id)
         => (await new Query().SelectSingle<dynamic>("[GetConclusion] @IdVisit", new { IdVisit = Id }));

        public async Task<DatabaseResult<dynamic>> GetVisitServices(int Id)
         => (await new Query().Select<dynamic>("[GetPatientCaseInvoiceServiceDetails] @IdVisit", new { IdVisit = Id }));

        public async Task<DatabaseResult<dynamic>> GetVisitPaymentCode(int Id)
        => (await new Query().Select<dynamic>("[GetPatientCasePaymentCode] @IdVisit", new { IdVisit = Id }));

        public async Task<DatabaseSingleResult<dynamic>> GetReferral(int Id)
       => (await new Query().SelectSingle<dynamic>("[GetReferal] @IdVisit", new { IdVisit = Id }));
    }
}
