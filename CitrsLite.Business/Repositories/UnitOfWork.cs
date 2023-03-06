using CitrsLite.Business.Repositories.Interfaces;
using CitrsLite.Data.Entity;
using CitrsLite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Repositories
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private CitrsLiteContext _context;
        private GenericRepository<Budwood> _budwoods;
        private GenericRepository<Participant> _participants;
        private GenericRepository<Registration> _registrations;
        private GenericRepository<Tree> _trees;
        private GenericRepository<TreeLocation> _treeLocations;
        private GenericRepository<TreeType> _treeTypes;
        private GenericRepository<VarietyClone> _varietyClones;

        public UnitOfWork(string connectionString)
        {
            _context = new CitrsLiteContext(connectionString);

        }

        private bool disposed = false;

        public IGenericRepository<Budwood> Budwoods
        {
            get
            {
                if (this._budwoods == null)
                {
                    this._budwoods = new GenericRepository<Budwood>(_context);
                }

                return _budwoods;
            }
        }

        public IGenericRepository<Participant> Participants
        {
            get
            {
                if (this._participants == null)
                {
                    this._participants = new GenericRepository<Participant>(_context);
                }

                return _participants;
            }
        }

        public IGenericRepository<Registration> Registrations
        {
            get
            {
                if (this._registrations == null)
                {
                    this._registrations = new GenericRepository<Registration>(_context);
                }

                return _registrations;
            }
        }

        public IGenericRepository<Tree> Trees
        {
            get
            {
                if (this._trees == null)
                {
                    this._trees = new GenericRepository<Tree>(_context);
                }

                return _trees;
            }
        }

        public IGenericRepository<TreeLocation> TreeLocations
        {
            get
            {
                if (this._treeLocations == null)
                {
                    this._treeLocations = new GenericRepository<TreeLocation>(_context);
                }

                return _treeLocations;
            }
        }

        public IGenericRepository<TreeType> TreeTypes
        {
            get
            {
                if (this._treeTypes == null)
                {
                    this._treeTypes = new GenericRepository<TreeType>(_context);
                }

                return _treeTypes;
            }
        }

        public IGenericRepository<VarietyClone> VarietyClones
        {
            get
            {
                if (this._varietyClones == null)
                {
                    this._varietyClones = new GenericRepository<VarietyClone>(_context);
                }

                return _varietyClones;
            }
        }

        /// <summary>
        /// Save database changes
        /// </summary>
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Save database changes
        /// </summary>
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
