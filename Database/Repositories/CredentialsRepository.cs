using System;
using System.Collections.Generic;
using System.Text;
using Database.Models;
using Database.Interfaces;

namespace Database.Repositories
{
    public class CredentialsRepository : BaseRepository<CredentialModel>, ICredentialsRepository
    {
        public CredentialsRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
