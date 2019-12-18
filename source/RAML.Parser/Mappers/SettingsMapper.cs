﻿using System.Collections.Generic;
using RAML.Parser.Model;
using RAML.Parser.Utils;

namespace RAML.Parser.Mappers
{
    internal class SettingsMapper
    {
        internal static Settings Map(IDictionary<string, object> settings)
        {
            if (settings == null)
                return null;

            return new Settings(ParameterMapperUtils.Map<string>(settings, "requestTokenUri"), ParameterMapperUtils.Map<string>(settings, "authorizationUri"),
                ParameterMapperUtils.Map<string>(settings, "tokenCredentialsUri"), 
                StringEnumerationMapper.Map(ParameterMapperUtils.Map<object[]>(settings, "signatures")), 
                ParameterMapperUtils.Map<string>(settings, "accessTokenUri"), 
                StringEnumerationMapper.Map(ParameterMapperUtils.Map<object[]>(settings, "authorizationGrants")), 
                FlowMapper.Map(settings["flows"] as object[]), ScopeMapper.Map(ParameterMapperUtils.Map<object[]>(settings, "scopes")), 
                ParameterMapperUtils.Map<string>(settings, "name"), ParameterMapperUtils.Map<string>(settings, "in"));
        }
    }
}