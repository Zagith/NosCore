﻿using AutoMapper;
using NosCore.Data;
using NosCore.Database;
using NosCore.Database.Entities;
using System;
using System.Linq;
using NosCore.Data.AliveEntities;
using NosCore.Data.StaticEntities;

namespace NosCore.DAL
{
    public static class DAOFactory
    {
        private static GenericDAO<Account,AccountDTO> _accountDAO;
        private static GenericDAO<Character, CharacterDTO> _characterDAO;
        private static GenericDAO<Map, MapDTO> _mapDAO;
        private static GenericDAO<MapNpc, MapNpcDTO> _mapNpcDAO;
        private static GenericDAO<NpcMonster, NpcMonsterDTO> _npcMonsterDAO;
        private static GenericDAO<Card, CardDTO> _cardDAO;
        private static GenericDAO<BCard, BCardDTO> _bcardDAO;
        private static GenericDAO<Item, ItemDTO> _itemDAO;
        private static GenericDAO<Quest, QuestDTO> _questDAO;
        private static GenericDAO<QuestReward, QuestRewardDTO> _questRewardDAO;
        private static GenericDAO<QuestObjective, QuestObjectiveDTO> _questObjectiveDAO;
        private static GenericDAO<Mate, MateDTO> _mateDAO;
        private static IMapper _mapper;

        public static GenericDAO<Account, AccountDTO> AccountDAO
        {
            get { return _accountDAO ?? (_accountDAO = new GenericDAO<Account, AccountDTO>(_mapper)); }
        }

        public static GenericDAO<Mate, MateDTO> MateDAO
        {
            get { return _mateDAO ?? (_mateDAO = new GenericDAO<Mate, MateDTO>(_mapper)); }
        }

        public static GenericDAO<Character, CharacterDTO> CharacterDAO
        {
            get { return _characterDAO ?? (_characterDAO = new GenericDAO<Character, CharacterDTO>(_mapper)); }
        }

        public static GenericDAO<Map, MapDTO> MapDAO
        {
            get { return _mapDAO ?? (_mapDAO = new GenericDAO<Map, MapDTO>(_mapper)); }
        }

        public static GenericDAO<MapNpc, MapNpcDTO> MapNpcDAO
        {
            get { return _mapNpcDAO ?? (_mapNpcDAO = new GenericDAO<MapNpc, MapNpcDTO>(_mapper));  }
        }

        public static GenericDAO<NpcMonster, NpcMonsterDTO> NpcMonsterDAO
        {
            get { return _npcMonsterDAO ?? (_npcMonsterDAO = new GenericDAO<NpcMonster, NpcMonsterDTO>(_mapper)); }
        }

        public static GenericDAO<Card, CardDTO> CardDAO
        {
            get { return _cardDAO ?? (_cardDAO = new GenericDAO<Card, CardDTO>(_mapper)); }
        }

        public static GenericDAO<BCard, BCardDTO> BcardDAO
        {
            get { return _bcardDAO ?? (_bcardDAO = new GenericDAO<BCard, BCardDTO>(_mapper)); }
        }

        public static GenericDAO<Item, ItemDTO> ItemDAO
        {
            get { return _itemDAO ?? (_itemDAO = new GenericDAO<Item, ItemDTO>(_mapper)); }
        }

        public static GenericDAO<Quest, QuestDTO> QuestDAO
        {
            get { return _questDAO ?? (_questDAO = new GenericDAO<Quest, QuestDTO>(_mapper)); }
        }

        public static GenericDAO<QuestReward, QuestRewardDTO> QuestRewardDAO
        {
            get { return _questRewardDAO ?? (_questRewardDAO = new GenericDAO<QuestReward, QuestRewardDTO>(_mapper)); }
        }

        public static GenericDAO<QuestObjective, QuestObjectiveDTO> QuestObjectiveDAO
        {
            get { return _questObjectiveDAO ?? (_questObjectiveDAO = new GenericDAO<QuestObjective, QuestObjectiveDTO>(_mapper)); }
        }

        public static void RegisterMapping(IMapper mapper)
        {
            _mapper = mapper;
        }
    }
}