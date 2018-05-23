using System;
using VirtualCnc.Configuration;
using Xunit;

namespace VirtualCnc.Tests
{
	public class ConfigurationTests
	{
		[Fact]
		public void SimpleConfigurationTest()
		{
			var cnc = new CncConfiguration
			{
				Channels = new []
				{
					new ChannelConfiguration
					{
						Name = "Channel 1",
						Axes = new []
						{
							new AxisConfiguration
							{
								Name = "X"
							}, 
							new AxisConfiguration
							{
								Name = "Y"
							},
							new AxisConfiguration
							{
								Name = "Z"
							},
						},
						Spindles = new []
						{
							new SpindleConfiguration
							{
								Name = "S"
							}, 
						}
					}, 
				}
			};
			
			var serializer = new ConfigurationSerializer();
			var xml = serializer.Serialize(cnc);
		}
	}
}