﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using JsonCSharpClassGenerator;

namespace Nustache.Core.Tests.Mustache_Spec.Examples.partials
{

    public class Context
    {
        public Context(JObject obj)
        {
            this.text = JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(obj, "text"));
        }

        public readonly string text;
    }

    public class Node
    {
        public Node(JObject obj)
        {
            this.content = JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(obj, "content"));
            this.nodes = (object[])JsonClassHelper.ReadArray<object>(JsonClassHelper.GetJToken<JArray>(obj, "nodes"), JsonClassHelper.ReadObject, typeof(object[]));
        }

        public readonly string content;
        public readonly object[] nodes;
    }

    public class Recursion
    {
        public Recursion(JObject obj)
        {
            this.content = JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(obj, "content"));
            this.nodes = (Node[])JsonClassHelper.ReadArray<Node>(JsonClassHelper.GetJToken<JArray>(obj, "nodes"), JsonClassHelper.ReadStronglyTypedObject<Node>, typeof(Node[]));
        }

        public readonly string content;
        public readonly Node[] nodes;
    }

    public class InlineIndentation
    {
        public InlineIndentation(JObject obj)
        {
            this.data = JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(obj, "data"));
        }

        public readonly string data;
    }

    public class StandaloneIndentation
    {
        public StandaloneIndentation(JObject obj)
        {
            this.content = JsonClassHelper.ReadString(JsonClassHelper.GetJToken<JValue>(obj, "content"));
        }

        public readonly string content;
    }

    public class PaddingWhitespace
    {
        public PaddingWhitespace(JObject obj)
        {
            this.boolean = JsonClassHelper.ReadBoolean(JsonClassHelper.GetJToken<JValue>(obj, "boolean"));
        }

        public readonly bool boolean;
    }

    public class partials
    {

        public partials(string json)
            : this(JObject.Parse(json))
        {
        }

        public partials(JObject obj)
        {
            this.Context = JsonClassHelper.ReadStronglyTypedObject<Context>(JsonClassHelper.GetJToken<JObject>(obj, "Context"));
            this.Recursion = JsonClassHelper.ReadStronglyTypedObject<Recursion>(JsonClassHelper.GetJToken<JObject>(obj, "Recursion"));
            this.InlineIndentation = JsonClassHelper.ReadStronglyTypedObject<InlineIndentation>(JsonClassHelper.GetJToken<JObject>(obj, "InlineIndentation"));
            this.StandaloneIndentation = JsonClassHelper.ReadStronglyTypedObject<StandaloneIndentation>(JsonClassHelper.GetJToken<JObject>(obj, "StandaloneIndentation"));
            this.PaddingWhitespace = JsonClassHelper.ReadStronglyTypedObject<PaddingWhitespace>(JsonClassHelper.GetJToken<JObject>(obj, "PaddingWhitespace"));
        }

        public readonly Context Context;
        public readonly Recursion Recursion;
        public readonly InlineIndentation InlineIndentation;
        public readonly StandaloneIndentation StandaloneIndentation;
        public readonly PaddingWhitespace PaddingWhitespace;
    }

}
